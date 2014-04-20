using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracilite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "New text";

            label1.Text = "Some text";

            RunScript();
        }

        public void RunScript()
        {
            ScriptEngine engine = Python.CreateEngine();
            ScriptSource source = engine.CreateScriptSourceFromString("target.label1.Text = bridge.GetSomething()");
            ScriptScope scope = engine.CreateScope();

            TraciliteBridge.BridgeClass bridge = new TraciliteBridge.BridgeClass();

            scope.SetVariable("target", this);
            scope.SetVariable("bridge", bridge);
            source.Execute(scope);
        }
    }
}
