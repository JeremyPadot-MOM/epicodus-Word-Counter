# _Word Counter_

#### _A C# Friday Code Review using MSTest March 6, 2020_

#### By _**Jeremy Padot**_


## Description

_A program that will gather both a word and sentence from a user, then checks how frequently the word appears in the sentence. It will check for full word matches only. _



## Behavior Driven Project Specifications

| Behavior | Input | Output |
|:---|:---:|:---:|
| User inputs two strings: a word, and a sentence| "cat", "Today I need to buy cat food for my cat so my cat can eat something" | creates new instance of user input |
| If user fails to include word, application will return an error | "", "Today I need to buy cat food for my cat so my cat can eat something"| error, you must include a word to be searched |
| If user inputs two strings: a word, and a sentence| "cat", "Today I need to buy cat food for my cat so my cat can eat something" | 3 |

## Setup/Installation Requirements

In your computer's terminal:

1. Navigate to where you want this application to be saved, i.e.:
```sh
cd desktop
```
2. Clone the file from GitHub with HTTPS
```sh
git clone 
```
3.  Enter into the new file directory
```sh
cd 
```
4.  Start the program
```sh
dotnet run
```

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue]() here on GitHub._

## Technologies Used

* C#
* .NET 2.0

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Jeremy Padot_**