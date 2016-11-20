using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class lltexthint : LollipopTextBox
    {
        private const string _text = @"Enter your full name";
        private bool _isEmpty = true;

        public lltexthint() {
            InitializeComponent();
            base.ForeColor = SystemColors.GrayText;
            Text = _text;
            Leave += LeaveTextBox;
            Enter += EnterTextBox;
            TextChanged += TextChangedTextBox;
        }

        private void TextChangedTextBox(object sender, EventArgs e) {
            _isEmpty = string.IsNullOrEmpty(Text);
        }

        public override sealed string Text {
            set {
                base.Text = value;
            }
        }

        private void LeaveTextBox(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(Text)) {
                Text = _text;
                _isEmpty = true;
                base.ForeColor = SystemColors.GrayText;
            } else {
                _isEmpty = false;
            }
        }

        private void EnterTextBox(object sender, EventArgs e) {
            if (_isEmpty)
                Text = string.Empty;

            base.ForeColor = SystemColors.ControlText;
        }
    }
}
