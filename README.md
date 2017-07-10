## Vending-Machine-Project

![vending-machine](https://media.licdn.com/mpr/mpr/p/3/005/093/1c1/3d3c719.jpg)

### Description
This is a C# solution for a vending machine that accepts only 50p coins but is able to dispense correct change in correct denominations.

- The vending machine must be allow customers to request a product (or products) and deposit the correct number of 50p coins

- The vending machine must respond to show that the correct product is provided along with the correct change


### Design
I separated the responsibilities of the vending machine in to three classes - Vending Machine, Product and Calculator. They are described below.

##### Vending Machine Class
* Responsible for interacting with the customer.

| Function  | Responsibility |
| ------ | ----------- |
| `DisplayItems()` | Outputs a line to the console for each product in its its inventory displaying the product name and product price. The inventory exists as an items array. |
| `RequestSelection()` | A list is created to hold product information which will be matched against customer input. A foreach loop is run. Dynamically, the first letter of each product available is added to the list and a line is output to the console requesting that that letter be used to request that product. customer input is received and passed to the find function. |
| `FindAndReturnProduct(char selection)` | The character representing the product choice of the customer is matched to a product in the items array of the vending machine. The `Array.find()` function is applied here. This function returns the product object. |
| `TakePayment(double coinsRequired, double change, Product product)` | The calculator class has a function that will return the number of coins required and and the change necessary. This function will request the customer to enter their payment. It will receive 50p coins until the number received matches the number stipulated by the calculator class. It will then call `ThankCustomer()`. |
| `ThankCustomer(paymentReceived, product.Name, change)` | This method clarifies the entire operation. It informs the customer of their purchase success. That they get their product and the correct change owed. |

##### Calculator Class
* Responsible for providing necessary payment information.

| Function  | Responsibility |
| ------ | ----------- |
| `ReturnPaymentAndChange(double productPrice)` | Passed only the price of the item, this method i) returns the number of 50p coins necessary for purchase and the corresponding change necessary. It executes a `Math.Ceiling()` function and a simple subtraction to calculate necessary change. These two doubles are returned as an array and passed to the Vending Machine `TakePayment()` function.  |

##### Product Class
* Responsible for encapsulation of the attributes purchase options.

| Attribute  | Responsibility |
| ------ | ----------- |
| Name | The display name of the given product |
| Price | The payment necessary for the purchase of the given product |


#### Considerations
- Wrong Coins being inserted
- Matching of input string requesting a product
- Incorrect product requests
- List created in `vendingMachine.RequestSelection()` is dynamic and is completely open for extension simply by adding more products to the Vending Machine items array.

#### Further Developments
I would like to extract the product inventory out to a separate class.
