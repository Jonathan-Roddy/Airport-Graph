using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GraphAssignment
{
    public partial class frmTravel : Form
    {
        public Graph graph = new Graph();
        public List<string> answer;
        public List<string> answer2;

        public frmTravel()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDeparture.Clear();
            txtArrival.Clear();
            txtDistance.Clear();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (graph.VerticesList.Contains(txtDeparture.Text) && graph.VerticesList.Contains(txtArrival.Text))
            {
                graph.RemoveEddge(txtDeparture.Text, txtArrival.Text);

                if (graph.ColumnIsEmpty(txtDeparture.Text) && graph.RowIsEmpty(txtDeparture.Text))
                    graph.RemoveVertex(txtDeparture.Text);

                if (graph.ColumnIsEmpty(txtArrival.Text) && graph.RowIsEmpty(txtArrival.Text))
                    graph.RemoveVertex(txtArrival.Text);


            }
            else
                MessageBox.Show("Such flight does not exist and can not be removed!");

            lbxFlightS.Items.Clear();
            answer = graph.Displaydetails();

            foreach (string place in answer)
                lbxFlightS.Items.Add(place);

        }

        private void btnSeek_Click(object sender, EventArgs e)
        {

            lbxFlightI.Items.Clear();
            answer2 = DepthFirstSearch(graph, txtDeparture.Text, txtArrival.Text);
            foreach (string place in answer2)
                lbxFlightI.Items.Add(place);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!graph.VerticesList.Contains(txtDeparture.Text))
                graph.AddVertex(txtDeparture.Text);
            if (!graph.VerticesList.Contains(txtArrival.Text))
                graph.AddVertex(txtArrival.Text);

            int edge_value = graph.WeightIs(txtDeparture.Text, txtArrival.Text);
            //if (edge_value != 0)
            //{
            //    DialogResult dialogResult = MessageBox.Show("Flight allready exist. Override value set?", "Information", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        graph.AddEdge(txtDeparture.Text, txtArrival.Text, Int32.Parse(txtDistance.Text));
            //    }
            //}
            //else
                graph.AddEdge(txtDeparture.Text, txtArrival.Text, Int32.Parse(txtDistance.Text));

            lbxFlightS.Items.Clear();
            answer = graph.Displaydetails();

            foreach (string place in answer)
                lbxFlightS.Items.Add(place);

        }


        public static List<string> DepthFirstSearch(Graph graph, string startVertex, string endVertex)
        {
            List<string> result = new List<string>();
            Stack<string> stack = new Stack<string>();
            Queue<string> vertexQ = new Queue<string>();
            bool found = false;
            string vertex;
            string item;
            graph.ClearMarks();
            stack.Push(startVertex);
            do
            {
                vertex = stack.Pop();
                if (vertex == endVertex)
                {
                    result.Add(vertex);
                    found = true;
                }
                else
                {
                    if (!graph.IsMarked(vertex))
                    {
                        graph.MarkVertex(vertex);
                        result.Add(vertex);
                        vertexQ = graph.GetToVertices(vertex, vertexQ);
                        while (vertexQ.Count != 0)
                        {
                            item = vertexQ.Dequeue();
                            if (!graph.IsMarked(item))
                                stack.Push(item);
                        }
                    }
                }
            } while (stack.Count != 0 && !found);
            if (!found)
                result.Add("Unfortunatly this Path is not found");
            return result;
        }
        public void frmTravel_Load(object sender, EventArgs e)
        {
            graph.AddVertex("Atlanta");
            graph.AddVertex("Austin");
            graph.AddVertex("Chicago");
            graph.AddVertex("Dallas");
            graph.AddVertex("Denver");
            graph.AddVertex("Houston");
            graph.AddVertex("Washington");


            graph.AddEdge("Atlanta", "Houston", 800);
            graph.AddEdge("Atlanta", "Washington", 600);
            graph.AddEdge("Austin", "Dallas", 200);
            graph.AddEdge("Austin", "Houston", 160);
            graph.AddEdge("Chicago", "Denver", 1000);
            graph.AddEdge("Dallas", "Austin", 200);
            graph.AddEdge("Dallas", "Chicago", 900);
            graph.AddEdge("Dallas", "Denver", 780);
            graph.AddEdge("Denver", "Atlanta", 1400);
            graph.AddEdge("Denver", "Chicago", 1000);
            graph.AddEdge("Houston", "Atlanta", 800);
            graph.AddEdge("Washington", "Atlanta", 600);
            graph.AddEdge("Washington", "Dallas", 1300);


            answer = graph.Displaydetails();
            foreach (string place in answer)
            {
                lbxFlightS.Items.Add(place);            

            }
            
        }
    }    
}

