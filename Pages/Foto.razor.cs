namespace BlazorAppVoorbeeld.Pages
{
    public partial class Foto
    {
        private string[] imagePaths = { "breakfast.jpg", "flower.jpg", "flower_red.jpg", "fontain.jpg", "lunch.jpg", "sunset.jpg" };
        private string currentImagePath = "images/breakfast.jpg";

        private void randomizeCurrentImagePath()
        {
            Random rnd = new Random();
            double num = rnd.NextDouble() * 6;
            num = Math.Floor(num);
            currentImagePath = "images/" + imagePaths[(int)num];
		}

	}
}
