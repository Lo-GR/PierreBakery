# **Bakery Application**
### This is a terminal application that will calculate the cost of items inputted by the user.

 ### _Contributor(s) and Contact Info_
> Logan Roth diamondintheroth@gmail.com - [GitHub(Lo-GR)](https://github.com/Lo-GR)

<br/>

## _Technologies Used_

* **C# 9**
* **.NET 5.0.102**
* **SDK 8.0.19**
* **MS Test**
* **Repel**

## _Description_
> [Click Here to View a Preview of UI](https://github.com/Lo-GR/PierreBakery/blob/main/img/currentUI.PNG?raw=true)

This an application built in C# with .NET 5.0 framework that will prompt the user through ordering Bread and Pastries then return those values and calculate the cost of each. On the business logic side, calculations are made automatically to account for deals and discounts.

This is a practice project for practicing C#, SDK, .NET framework,MS TEst, and Classes for a course at Epicodus.

**To view Specs, visit the [ModelTests](https://github.com/Lo-GR/PierreBakery/tree/main/Bakery.Tests/ModelTests) section of GitHub**

## _Use Guide_

> Repository: https://github.com/Lo-GR/PierreBakery.git
1. Clone the above repository from Github.
2. Navigate to the Bakery.Tests directory in the terminal and run "dotnet restore" to build out test environment.
3. In your terminal, navigate to Bakery directory and run "dotnet build" to build application within directory. 
4. In your terminal, while still in Bakery directory, run "dotnet run" to run application within terminal. Follow the instructions outlined in the terminal.
5. Open the project in your text editor to view the code.


## _Known Bugs_
* No known bugs at this time. Please contact a contributor to report any bugs found during use.

## _Future Updates_
* Additional UI
* Additional Bread and Pastry options

## _Preplanning/Whiteboard Work_

```
Expectations___

- There should be two classes: one for Bread and one for Pastry.
- When the user runs the application, they should receive a prompt with a welcome message along with the cost for both Bread and Pastry.
- A user should be able to specify how many loaves of Bread and how many Pastrys they'd like.
- The application will return the total cost of the order.
- Pierre offers the following deals:

Bread Base Price = 5; BOGO offered
Pastry base price = 2; 3 for 5.
Every third pastry price adds a dollar discount
All functionality for the models should be tested

Need to add auto implemented properties somehow.

Functionality___
- Bread class should contain function that returns cost of bread.
- Bread class should contain function that accounts for buy 2 deal.
- Pastry class should contain a function that returns cost of pastry. 
- Pastry should contain function that accounts for buy 3 deal.
v-Stretch Goal-v
- Shopping Cart class constructor which will take in Bread and Pastry information. 
- Shopping cart will use auto implemented properties


User Interface___
This is the UI for the basic MVP.
1. Introduction to bakery with prompts for prices
2. Asks how many bread they would like. Receives number and creates Bread object with that amount.
3. Asks how many pastries they would like. Receives number and creates Pastry object with that amount.
4. Return price of Bread and price of pastry.
5. Return total price of order.
```
## _License_

[_MIT_](https://opensource.org/licenses/MIT)

Copyright (c) 2021, Logan Roth.

Please contact Contributor for further use information or if you would like to make a contribution.