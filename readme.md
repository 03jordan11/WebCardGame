
## Our goal is to create a fast and efficient web application that supports multiple card games which will provide an online platform for existing games while introducing new ones in an accessible form. This vision will give exposure to card games of a cultural nature. This is a shared vision that will be open source as to broaden the range of our domain and bring the joy of niche games to a broader audience.

How To Compile:
1. Download the .NET core SDK from https://www.microsoft.com/net/download based on platform. 
2. Clone project onto machine.
3. Open project using Visual Studio or Visual Studio Code by selecting "open project" from file menu ans selecing the project (.sln) file
4. Run file through Visual Studio
5. NOTE: A test version will be available through HTTP in the future

Git Structure-Branches:
1. Master
    - Used for the initial project, but not touched so that a diff can be performed later
2. Develop
    - Used as the working branch for the project, all *finished* code will be pushed here
    - Most of the work will not reside here until project completeion
3. Features
    - These will branch from the current Develop branch and will be used to work on individual feautres of the project
    - They will have a numerical label and description indicating what the branch contains i.e. #001_Login_Page
    - Will be merged into Develop after thorough review and testing.

[Documentation](https://drive.google.com/drive/folders/1LZWzqJHkDROf3FxlJqt9z19stl5ErKpn?usp=sharing)