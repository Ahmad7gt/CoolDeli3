using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductApi.Migrations
{
    public partial class int4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "Details", "Enabled", "Image", "Instock", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Ham is traditionally pork cut from a hog’s hind leg that has been preserved through salting, smoking or curing. However, it’s also possible to get chicken ham, preserved in the same manner. Ham is available in a variety of flavours; some of my favourites are honey-glazed ham, Serrano ham, which is a Spanish variety, Prosciutto, an Italian dry-cured ham and Black Forest ham, a German variety. Ham can be served as is, or baked, boiled or fried. It works well with sweet potatoes, tomatoes and white wine.", true, "https://www.hungryforever.com/wp-content/uploads/2015/04/ham_compressed-293x300.jpg", true, "Ham", "90" },
                    { 2, "Salami is also traditionally pork, or beef, which is seasoned with garlic, minced fat, salt, spices, wines and a range of herbs. Popular salami varieties are chorizo, pepperoni (bet you’ve heard of that one) and Saucisson sec. Salami tastes good on pizzas, in pastas, or simply in sandwiches.", true, "https://www.hungryforever.com/wp-content/uploads/2015/04/sliced-salami_compressed-300x214.jpg", true, "Salami", "150" },
                    { 3, "Either beef or pork is slow roasted, and served as a whole meal. Leftovers are then used in sandwiches and other recipes. Roast beef is the signature national dish of England, so if you’re hosting a British themed party, be sure to serve some up.", true, "https://www.hungryforever.com/wp-content/uploads/2015/04/beef_compressed-300x208.jpg", true, "Roast Meat", "120" },
                    { 4, "To prepare traditional meatloaf, beef is ground, mixed with spices and herbs, formed into a loaf shape and then baked or smoked. Meatloaf can also be made from lamb, pork, seafood, veal, venison and poultry. It can be served with rice or potatoes with a side of veggies, or spread on a sandwich.", true, "https://www.hungryforever.com/wp-content/uploads/2015/04/meatloaf_compressed-300x201.jpg", true, "Meatloaf", "70" },
                    { 5, "Bierwurst is a German sausage seasoned with pepper, mustard seeds and paprika. It is often eaten as a snack with beer.", true, "https://www.hungryforever.com/wp-content/uploads/2015/04/bierwurst_compressed-300x225.jpg", true, "Bierwurst", "50" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
