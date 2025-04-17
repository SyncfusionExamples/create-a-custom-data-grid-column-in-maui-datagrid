namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        EmployeeViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            dataGrid.CellRenderers.Add("Stepper", new StepperColumnRenderer());
        }
    }
}
