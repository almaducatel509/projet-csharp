using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HopitalEspoirDelmas
{
    public static class Utils{
        
        public static bool InArray(string el, object[] tab)
        {
            bool r = false;
            foreach (string e in tab)
            {
                if (e.Equals(el))
                {
                    r = true;
                    break;
                }
            }
            return r;
        }
        
        public static string[] Split(string chaine, string separator)
        {
            int k = 0, j = 0, l = -1;
            string curr = "", part = "";
            string[] _r = new string[chaine.Length], r;
            for(int i = 0; i < chaine.Length; i++)
            {
                l = l == -1 ? i : l;
                if (curr.Length == 0)
                {
                    if (separator.Length > 0 && separator[0] == chaine[i]) curr += chaine[i];
                }
                else curr += chaine[i];

                if (curr.Length == separator.Length && !separator.Equals(curr)) curr = "";
                
                if (separator.Equals(curr) && separator.Length > 0)
                {
                    for (int _i = l; _i < i; _i++)
                    {
                        part += chaine[_i];
                    }
                    _r[k] = part;
                    part = "";
                    curr = "";
                    l = -1;
                    j = i;
                    k++;
                }
                else if (separator.Equals(""))
                {
                    _r[k] = chaine[i].ToString();
                    l = -1;
                    k++;
                }
                
                if (i == chaine.Length - 1 && l > -1 && !separator.Equals(""))
                {
                    for (int _i = l; _i <= i; _i++)
                    {
                        part += chaine[_i];
                    }
                    _r[k] = part;
                    k++;
                }
            }

            r = new string[k];
            for (int i = 0; i < k; i++)
            {
                r[i] = _r[i];
            }
            return r;
        }

        public static string Join(object[] array, string glue)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0, j = array.Length; i < j; i++)
            {
                sb.Append(array[i].ToString() + (i < j - 1 ? "," : ""));
            }
            return sb.ToString();
        }
    }
    
    public abstract class ICCommutation : UserControl
    {
        
        protected Label label;
        protected Panel body;
        protected string[] options;
        protected string text;
        protected List<EventHandler> events;

        public string Text 
        { 
            get { return text; }
            set { setChecked(value); }
        }

        public string LabelText
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public ICCommutation(string _label, string[] options)
        {
            label = new Label() {Text = _label};
            body = new Panel();
            this.options = options;
            events = new List<EventHandler>();
            this.SuspendLayout();
            
            label.Height = 20;
            label.Font = new Font("Arial", 10);
            label.Dock = DockStyle.Top;

            body.Dock = DockStyle.Fill;
            
            this.Controls.AddRange(new Control[]{body, label});
            setOptions();
            this.ResumeLayout();
        }

        public ICCommutation(string label) : this(label, new string[] { }){}
        
        public ICCommutation() :this(""){}

        public void adjustSize()
        {
            int height = label.Height;
            height += body.Controls.Count * 20;
            this.Height = height;
        }

        protected abstract void setOptions();

        public void setOptions(string[] options)
        {
            this.options = options;
            text = null;
            setOptions();
        }

        public void OnTextChange(EventHandler e)
        {
            events.Add(e);
        }

        protected void FireTextChangeEvent()
        {
            foreach (var ev in events)
            {
                ev.Invoke(this, EventArgs.Empty);
            }
        }

        protected abstract void onChoice(object sender, EventArgs e);

        protected abstract void setChecked(string text);
    }
    public class ICSwitch : ICCommutation
    {
        private RadioButton[] radios;
        public ICSwitch(string _label, string[] options) : base(_label, options) {}

        public ICSwitch(string label) : this(label, new string[] { }){}
        
        public ICSwitch() :this(""){}

        protected override void setOptions()
        {
            if (options == null) return;
            body.SuspendLayout();
            body.Controls.Clear();
            radios = new RadioButton[options.Length];
            int i = 0;
            foreach (var item in options)
            {
                radios[i] = new RadioButton()
                {
                    Text = item.ToString(),
                    Dock = DockStyle.Top,
                    Height = 20
                };
                radios[i].Click += onChoice;
                i++;
            }
            body.Controls.AddRange(radios);
            adjustSize();
            body.Refresh();
            body.ResumeLayout();
        }

        protected override void onChoice(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton) sender;
            text = rd.Text;
            FireTextChangeEvent();
        }

        protected override void setChecked(string text)
        {
            bool found = false;
            foreach (RadioButton rd in body.Controls)
            {
                rd.Checked = !found ? rd.Text.Equals(text) : false;
                if (!found && rd.Text.Equals(text))
                {
                    FireTextChangeEvent();
                }
                found = !found ? rd.Text.Equals(text) : found;
            }

            if (found) this.text = text;
        }
    }

    public class ICList : ICCommutation
    {
        
        private CheckBox[] check;
        private string textIndex;

        public string TextFromIndex
        {
            get { return textIndex; }
        }
        public ICList(string _label, string[] options) : base(_label, options) {}

        public ICList(string label) : this(label, new string[] { }){}
        
        public ICList() :this(""){}

        protected override void setOptions()
        {
            if (options == null) return;
            check = new CheckBox[options.Length];
            body.SuspendLayout();
            body.Controls.Clear();
            text = null;
            int i = 0;
            foreach (var item in options)
            {
                check[i] = new CheckBox()
                {
                    Text = item.ToString(),
                    Name = item.ToString(),
                    Dock = DockStyle.Top,
                    Height = 20,
                    Width = 100,
                    ForeColor = Color.Black
                };
                check[i].Click += onChoice;
                i++;
            }
            body.Controls.AddRange(check);
            body.Refresh();
            body.ResumeLayout();
            adjustSize();
        }

        protected override void onChoice(object sender, EventArgs e)
        {
            CheckBox rd = (CheckBox) sender;
            text = Utils.Join(list(), ",");
            FireTextChangeEvent();
        }

        private string[] list()
        {
            List<string> items = new List<string>();
            List<string> indexes = new List<string>();
            int i = 0;
            foreach (CheckBox cb in body.Controls)
            {
                if (cb.Checked)
                {
                    items.Add(cb.Text);
                    indexes.Add(i.ToString());
                }
                i++;
            }
            textIndex = Utils.Join(indexes.ToArray(), ",");
            return items.ToArray();
        }

        protected override void setChecked(string text)
        {
            if (text == null || text.Length == 0) return;
            string[] choices = Utils.Split(text, ",");
            string list = "", indexes = "";
            int i = 0;
            bool found = false;
            foreach (CheckBox rd in body.Controls)
            {
                rd.Checked = Utils.InArray(rd.Text, choices);
                if (rd.Checked)
                {
                    list += (list.Length == 0 ? "" : ",") + rd.Text;
                    indexes += (indexes.Length == 0 ? "" : ",") + i.ToString();
                    FireTextChangeEvent();
                }
                found = found ? found : Utils.InArray(rd.Text, choices);
                i++;
            }

            if (found)
            {
                this.text = list;
                this.textIndex = indexes;
            }
        }
    }
}
