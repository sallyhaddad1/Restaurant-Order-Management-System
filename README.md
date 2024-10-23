# Burger Order Management System

This project is a Windows Forms application designed to manage burger orders, including various flavors, ingredients, and order details. The program allows users to select the type of burger (Beef, Chicken, or Kids), customize it with additional ingredients, and calculate the total price based on the selections made.

## Features

- **Dynamic Burger Selection**: Choose between different types (Beef, Chicken, Kids) and select various flavors such as Grill Harley, White Mushroom, Maxican, and Happy Meal.
- **Ingredient Customization**: Customize your order with optional ingredients like Pepper, Onions, Paprika, and Cheese.
- **Image Handling**: Open and save images of burgers in different formats (GIF, PNG, JPEG, JPG).
- **Order Validation**: Ensures correct inputs such as name, phone number, burger type, flavor, and quantity.
- **Price Calculation**: Dynamically calculates the total price of the order based on the selected burger type, flavor, option (Meal or Sandwich), and quantity.
- **Real-Time Visual Effects**: A timer changes the label color and burger image randomly to enhance the visual appeal.
- **Order Summary**: Displays a summary of the order in a DataGridView.
- **Order and Interface Control**:
  - Clear order option
  - Reset interface fields
  - Start/Stop timer for visual effects
  - Exit application

## Dependencies

- .NET Framework
- Windows Forms (WinForms)

## How to Use

1. **Burger Selection**:
   - Choose a burger type from the dropdown (`Beef`, `Chicken`, `Kids`).
   - Depending on the type, the flavor list will be populated with different options (e.g., Grill Harley, White Mushroom, Maxican, Happy Meal).
   
2. **Select Ingredients**:
   - Add optional ingredients from the `CheckedListBox`.
   - Valid selections include Pepper, Onions, Paprika, Cheese.

3. **Quantity & Customer Details**:
   - Enter the desired quantity of burgers.
   - Provide the customer name and phone number.

4. **Calculate Total**:
   - The total price is calculated based on the burger type, flavor, and ingredients.
   - Click on "Print Order" to view the final order and its price.

5. **Image Handling**:
   - Load an image: Go to the `File` menu and select `Open Image` to load a burger image.
   - Save an image: Save the loaded image using the `Save Image As` option in the menu.
   
6. **Timer-Based Visuals**:
   - Start the timer by selecting `Start` from the menu.
   - The label color and image will change randomly at set intervals.

7. **Order Management**:
   - Click on `Print Order` to confirm and add the order to the summary table.
   - Use the `Clear Order` option to reset all fields and inputs.

## Error Handling

- Ensures valid numeric input for quantities.
- Displays error messages if any required fields are left empty or if invalid data is entered.




