using Syncfusion.Maui.TreeView;
using Syncfusion.TreeView.Engine;

namespace MauiTreeView
{
    public partial class MainPage : ContentPage
    {
        SfTreeView TreeView;
        public MainPage()
        {
            InitializeComponent();
            TreeView = treeView;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var imageIcon = sender as Image;
            var treeViewNode = imageIcon!.BindingContext as TreeViewNode;
            if (treeViewNode!.IsExpanded)
                TreeView.CollapseNode(treeViewNode);
            else
                TreeView.ExpandNode(treeViewNode);
        }
    }
}
