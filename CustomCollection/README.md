# Generic Collection Console App

**Author**: Ariel R. Pedraza <br />
**Version**: 1.0.0

## Overview
<b>Purpose:</b><br />
This application demonstrates the use of custom generic collections. 
<br />

<b>Summary:</b><br />
Generic Custom Collection Type called Store allows you to add or remove items to/from the collection. It also allows getting an object from the from the collection by a certain index location. Main program class has a method for printing all objects in the collection as well.
<br />

<b>App Details:</b><br />
Add() method: Will resize the collection to 50% larger when capacity reaches greater than 70%.<br />
Remove() method: Will resize the collection to 50% smaller when capacity reaches less than 30%.<br />
<br />

## Getting Started
The following is required to run the program.
1. Visual Studio 2017 
2. The .NET desktop development workload enabled 

## Example

```
Collection size before add: 10
Property Count: 8
Array > 70% capacity! Increasing array size by 50%!
Collection size after add: 15
Property Count: 9

Collection size before add: 15
Property Count: 9
Collection size after add: 15
Property Count: 10

Called GetAtIndex(2):
Pixel 2 XL

Called ViewAll():
All items currently in the collection:
iPhone X
Surface Book 2
Pixel 2 XL
Surface Pro 4
Area 51
PS4 Slim
PS4 Pro
XBox One
XBox One X
Switch

Calling Remove() on 9 items. Switch will be the only one left:
Collection size before remove: 15
Property Count: 10
Found item at index 3 during remove method.
Removing item by shifting everything after it over by one!
Collection size after remove: 15
Property Count: 9
```

## Architecture
This application is created using ASP.NET Core 2.0 Console applicaitons. <br />
*Language*: C# <br />
*Type of Applicaiton*: Console Application <br />