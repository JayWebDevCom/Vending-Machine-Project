## Vending-Machine-Project

![vending-machine](https://media.licdn.com/mpr/mpr/p/3/005/093/1c1/3d3c719.jpg)


### Description
This is a C# solution for a vending machine that accepts only 50p coins but is able to dispense correct change in correct denominations.

- The vending machine must be allow users to request a product (or products) and deposit the correct number of 50p coins

- The vending machine must respond to show that the correct product is provided along with the correct change


### Design
I separated the responsibilities of the vending machine in to three classes - Vending Machine, Product and Calculator. They are described below.

##### Vending Machine Class
* Responsible for interacting with the customer.

| Method  | Responsibility |
| ------ | ----------- |
| `DisplayItems()` | Outputs a line to the console for each product in its its inventory displaying the product name and product price. The inventory exists as an items array. |
| `RequestSelection()` | A list is created to hold product information which will be matched against user input. A foreach loop is run. Dynamically, the first letter of each product available is added to the list and a line is output to the console requesting that that letter be used to request that product. User input is received and passed to the find method. |
| `Find(char selection)` | The character representing the product choice of the user is matched to a product in the items array of the vending machine. The `Array.find()` method is applied here. This method returns the product object. |
| `TakePayment(double coinsRequired, double change, Product product)` |  \ |


#### Considerations
- Wrong Coins being inserted
- Matching of input string requesting a product
- Incorrect product requests
- List created in `vendingMachine.RequestSelection()` is dynamic and is completely open for extension simply by adding more products to the Vending Machine items array.

#### Further Developments
I would like to extract the product inventory out to a separate class.
