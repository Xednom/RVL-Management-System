using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace RVL_Management_System.Panel
{
    public partial class PnlTask : UserControl
    {
        Form _owner = null;
        bool _loaded = false;

        //events
        #region Events
        public event EventHandler Closed;
        public event EventHandler Shown;

        protected virtual void closed(EventArgs e)
        {
            EventHandler handler = Closed;

            if (handler != null) handler(this, e);
        }

        protected virtual void shown(EventArgs e)
        {
            EventHandler handler = Shown;

            if (handler != null) handler(this, e);
        }
        #endregion

        public PnlTask()
        {
            InitializeComponent();
        }

        public PnlTask(Form owner) : this()
{
            this.Visible = false;

            _owner = owner;
            owner.Controls.Add(this);
            this.BringToFront();
            owner.Resize += owner_Resize;
            //this.Click += pnlTask_Click;
            ResizeForm();
        }
        //when the form is clicked
        //it will close

        void pnlTask_Click(object sender, EventArgs e)
        {
            Frm_Main fmain = new Frm_Main();
            fmain.btn_task.Enabled = true;
        }

        void owner_Resize(object sender, EventArgs e)
        {
            ResizeForm();
        }

        //This will determine the size of you panel
        //77 - is to remove the header and footer
        //50 - is for top position. You can change it depending on your design
        private void ResizeForm()
        {
            //this.Width = _owner.Width;
            //this.Height = _owner.Height;
            this.Location = new Point(_loaded ? 0 : _owner.Width, 40);

        }

        public void swipe(bool show = true)
        {
            this.Visible = true;
            Transition _transasition = new Transitions.Transition(new TransitionType_EaseInEaseOut(600));
            _transasition.add(this, "Left", show ? 350 : this.Width);
            _transasition.add(this, "Top", show ? 100 : this.Height);
            _transasition.run();



            while (this.Left != (show ? 0 : this.Width))
            {
                Application.DoEvents();
            }

            if (!show)
            {
                closed(new EventArgs());
                _owner.Resize -= owner_Resize;
                _owner.Controls.Remove(this);
                this.Dispose();
            }
            else
            {
                //basing on the previous form size
                _loaded = true;
                ResizeForm();
                shown(new EventArgs());
            }
        }

        private void PnlTask_Load(object sender, EventArgs e)
        {

        }
    }
}
