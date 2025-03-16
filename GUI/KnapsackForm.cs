using lab2_Knapsack;

namespace GUI
{
    public partial class KnapsackForm : Form
    {
        private Knapsack instance;
        private Result result;
        public KnapsackForm()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(seedTextBox.Text, out int seed))
            {
                MessageBox.Show("Seed must be an integer.");
                return;
            }

            if (!int.TryParse(numberOfItemsTextBox.Text, out int numberOfItems) || numberOfItems <= 0)
            {
                MessageBox.Show("Number of items must be an integer greater than 0.");
                return;
            }

            if (!int.TryParse(capacityTextBox.Text, out int capacity) || capacity <= 0)
            {
                MessageBox.Show("Capacity must be an integer greater than 0.");
                return;
            }

            instance = new Knapsack(numberOfItems, seed, capacity);
            generatedLst.Items.Clear();
            generatedLst.Columns.Clear();

            generatedLst.Columns.Add("ID", 50, HorizontalAlignment.Left);
            int columnWidth = (generatedLst.Width - 80) / 2;
            generatedLst.Columns.Add("Weight", columnWidth, HorizontalAlignment.Left);
            generatedLst.Columns.Add("Value", columnWidth, HorizontalAlignment.Left);

            foreach (var item in instance.Items)
            {
                ListViewItem row = new ListViewItem(item.Index.ToString());
                row.SubItems.Add(item.Weight.ToString());
                row.SubItems.Add(item.Value.ToString());
                generatedLst.Items.Add(row);
            }
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            if (instance == null || instance.Items.Count == 0)
            {
                MessageBox.Show("You need to generate instance first.");
                return;
            }
            result = new Result(KnapsackSolver.Solve(instance));
            selectedLst.Items.Clear();
            selectedLst.Columns.Clear();

            selectedLst.Columns.Add("ID", 50, HorizontalAlignment.Left);
            int columnWidth = (generatedLst.Width - 80) / 2;
            selectedLst.Columns.Add("Weight", columnWidth, HorizontalAlignment.Left);
            selectedLst.Columns.Add("Value", columnWidth, HorizontalAlignment.Left);

            foreach (var item in result.Items)
            {
                ListViewItem row = new ListViewItem(item.Index.ToString());
                row.SubItems.Add(item.Weight.ToString());
                row.SubItems.Add(item.Value.ToString());
                selectedLst.Items.Add(row);
            }
            totalWeightLbl.Text = $"Total weight: {result.totalWeight}";
            totalValueLbl.Text = $"Total value: {result.totalValue}";
        }
    }
}
