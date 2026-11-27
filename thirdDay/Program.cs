using thirdDay.Models;
Console.WriteLine("Hello, World!");


List<ExpenseItem> expenses = new List<ExpenseItem>
{
    new ExpenseItem { Id = 1, Title = "Biryani Lunch", Category = "Food", Amount = 650m },
    new ExpenseItem { Id = 2, Title = "Bykea Ride", Category = "Transport", Amount = 320m },
    new ExpenseItem { Id = 3, Title = "Groceries", Category = "Food", Amount = 2450m },
    new ExpenseItem { Id = 4, Title = "Internet Package", Category = "Utilities", Amount = 1800m },
    new ExpenseItem { Id = 5, Title = "Metro / Bus Fare", Category = "Transport", Amount = 150m },
    new ExpenseItem { Id = 6, Title = "Coffee", Category = "Food", Amount = 450m }
};

HashSet<string> uniqueCategories = new HashSet<string>();

Dictionary<string, List<ExpenseItem>> groupedExpenses = new Dictionary<string, List<ExpenseItem>>();


foreach (var expense in expenses)
{
    string normalizedCategory = string.IsNullOrWhiteSpace(expense.Category)
        ? "Uncategorized"
        : expense.Category.Trim();

    uniqueCategories.Add(normalizedCategory);

    if (!groupedExpenses.ContainsKey(normalizedCategory))
    {
        groupedExpenses[normalizedCategory] = new List<ExpenseItem>();
    }

    groupedExpenses[normalizedCategory].Add(expense);
}


// 4. Summary print karna
Console.WriteLine($"Total Expenses Count: {expenses.Count}");
Console.WriteLine($"Unique Categories ({uniqueCategories.Count}): {string.Join(", ", uniqueCategories)}");
Console.WriteLine(new string('-', 50));

foreach (var pair in groupedExpenses)
{
    string categoryName = pair.Key;
    List<ExpenseItem> itemsInCategory = pair.Value;

    decimal categoryTotal = 0m;
    foreach (var item in itemsInCategory)
    {
        categoryTotal += item.Amount;
    }

    Console.WriteLine($"Category: {categoryName} | Count: {itemsInCategory.Count} | Total: PKR {categoryTotal:N2}");

    foreach (var item in itemsInCategory)
    {
        Console.WriteLine($"   - {item.FormatLine()}");
    }
}