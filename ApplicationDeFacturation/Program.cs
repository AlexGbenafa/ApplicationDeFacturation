// See https://aka.ms/new-console-template for more information
using ApplicationDeFacturation.Models;
namespace ApplicationDeFacturation
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.affichage();
        }
    }
}