using System;
using System.Windows.Forms;

namespace NodeOptimization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Node a = new Node("A");
            Node b = new Node("B");
            Node c = new Node("C");
            Node d = new Node("D");
            Node e = new Node("E");

            d.Dest = true;
            e.Dest = true;

            a.Fire += b.ReceiveInput;
            a.Fire += c.ReceiveInput;
            a.Fire += e.ReceiveInput;

            b.Fire += d.ReceiveInput;
            c.Fire += d.ReceiveInput;
            c.Fire += e.ReceiveInput;

            d.Fire += ToDest;
            e.Fire += ToDest;

            a.PathReady += A_PathReady;

            // artificially fire A
            a.ReceiveInput(new Node("0"));
        }
        
        private void A_PathReady(Node n)
        {
            n.FireDownstream("D");
            n.FireDownstream("E");
        }

        private void ToDest(Node upstream)
        {
            //Console.WriteLine(upstream.Name + " to dest");
            upstream.LoopBack(upstream);
        }
        
    }
}
