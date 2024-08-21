# Asciify Text
This is a simple project designed to reciever text and return it in the form of ascii art.

## How to run 
Simply run ```dotnet run``` after cloning the repo

## Functionality
You can asciify your text by passing it to the url as a parameter.
For example, to asciify your text, type: ```localhost:5187/{text}```
If you want to change the type of font used to asciify your text, the API accepts an optional font parameter,
for example: ```localhost:5178/{text}?{font}```
To get all possible fonts, go to: ```localhost:5187/``` 

## TODO
- [ ] Add pagination to font list
- [ ] Add sorting to font list
