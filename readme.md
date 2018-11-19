
## Our goal is to create a fast and efficient web application that supports multiple card games which will provide an online platform for existing games while introducing new ones in an accessible form. This vision will give exposure to card games of a cultural nature. This is a shared vision that will be open source as to broaden the range of our domain and bring the joy of niche games to a broader audience.

## How To Compile:
1. Download the .NET core SDK from https://www.microsoft.com/net/download based on platform. 
2. Clone project onto machine.
3. Open project using Visual Studio or Visual Studio Code by selecting "open project" from file menu ans selecing the project (.sln) file
4. Run file through Visual Studio
5. NOTE: See a working version at cardroot.tk

## Git Structure-Branches:
1. Master
    - Used for the initial project, but not touched so that a diff can be performed later
2. Develop
    - Used as the working branch for the project, all *finished* code will be pushed here
    - Most of the work will not reside here until project completeion
3. Features
    - These will branch from the current Develop branch and will be used to work on individual feautres of the project
    - They will have a numerical label and description indicating what the branch contains i.e. #001_Login_Page
    - Will be merged into Develop after thorough review and testing.

## How To Contribute
NOTE: These steps assume that you have a basic knowledge of web programming and git. You do NOT need to know how to use .NET core, however it helps.

1. Create a feature branch from the current develop branch using the title ##xxxMyGame. In place of xxx you will put the UID of your game which will be the next number in the the features list. So, if the last feature worked on was called #234Chess, your game would be called ##235MyGame.
2. Open the project using Visual Studio and look for the Controllers folder. Use the template found HERE to create a class called YourGameController.cs
3. In the views folder, create a folder called YourGame
4. In that folder, use THIS templte to create a file called Index.cshtml
5. Create a button on the homepage so that it links to your game as shown here.
6. CHeck to make sure the link works, then begin to create your game using the Index file.
7. Once finished, creat a pull request to develop and await review.

## Contributors
1. Aabhas Kharel @aabhaskharel
2. Justine Batongmalaki @jbt296
3. Jordan Burnes @03jordan11

## Resources Used
1. https://www.transparenttextures.com/
2. https://html-css-js.com/css/generator/text-shadow/
[Documentation](https://drive.google.com/drive/folders/1LZWzqJHkDROf3FxlJqt9z19stl5ErKpn?usp=sharing)
