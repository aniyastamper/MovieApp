using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Views;

public partial class FindPage : ContentPage
{
    public FindPage()
    {
        InitializeComponent();
    }
    
    protected override void OnAppearing()
    {
        base.OnAppearing();
        var MovieTemplate = new DataTemplate(typeof(TextCell)); //is a C# object 
        MovieTemplate.SetBinding(TextCell.TextProperty, "Title");
        MovieTemplate.SetBinding(TextCell.DetailProperty,"Rating");

        ListMovies.ItemTemplate = MovieTemplate;
        ListMovies.ItemsSource = App.MovieList;
    }
    
}