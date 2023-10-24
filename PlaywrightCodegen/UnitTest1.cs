using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;

namespace PlaywrightCodegen
{


	[Parallelizable(ParallelScope.Self)]
	[TestFixture]
	public class Tests : PageTest
	{
		[Test]
		public async Task MyTest()
		{
			await Page.GotoAsync("http://localhost:64978/Product");

			await Page.GetByRole(AriaRole.Link, new() { Name = "Create New" }).ClickAsync();

			await Page.GetByLabel("product name").ClickAsync();

			await Page.GetByLabel("product name").PressAsync("CapsLock");

			await Page.GetByLabel("product name").FillAsync("B");

			await Page.GetByLabel("product name").PressAsync("CapsLock");

			await Page.GetByLabel("product name").FillAsync("Banana");

			await Page.GetByLabel("Price").ClickAsync();

			await Page.GetByLabel("Price").FillAsync("0.60");

			await Page.GetByLabel("description").ClickAsync();

			await Page.GetByLabel("description").PressAsync("CapsLock");

			await Page.GetByLabel("description").FillAsync("Y");

			await Page.GetByLabel("description").PressAsync("CapsLock");

			await Page.GetByLabel("description").FillAsync("Yellow ");

			await Page.GetByLabel("description").PressAsync("CapsLock");

			await Page.GetByLabel("description").FillAsync("Yellow B");

			await Page.GetByLabel("description").PressAsync("CapsLock");

			await Page.GetByLabel("description").FillAsync("Yellow Banana");

			await Page.GetByRole(AriaRole.Button, new() { Name = "Create" }).ClickAsync();

		}
	}
}