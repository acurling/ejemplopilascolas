using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Queue<int> cola = new Queue<int>();  // queque  dequeque
        Stack<int> pila = new Stack<int>();  // pop  push
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pila.Push(int.Parse(textBox1.Text));
            lvalores.Text = lvalores.Text+ " - " + textBox1.Text;
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
                textBox1.Text = pila.Pop().ToString();
            else textBox1.Text = "Pila esta vacia";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cola.Enqueue(int.Parse(textBox1.Text));
            lvalores.Text = lvalores.Text + " - " + textBox1.Text;
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (cola.Count>0)
            textBox1.Text = cola.Dequeue().ToString();
            //else textBox1.Text = "Cola esta vacia";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = cola.Count().ToString();
        }
    }
}
