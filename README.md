# Bewander

This repository shows my contribution to the Bewander website. Specifically - I was tasked with the flag modal and ensuring its functionality in relation with the flag data table.

# Contributions

My specific contribution to this project has to do with the flag modal in both the front end and back end. When I took over, the flag modal was present but it looked very bland and wasn't communicating with the flag data table properly. Whenever a user would try to flag something, it wouldn't create the flag at all for the admin to view. The flag modal was also built originally as a radio button selection, which was an eyesore to the end user.

I have numbered the code snippets and pictures in this repository so that I can explain what I did for this project.

In code snippet 1-EnumModel I built an enum so that the drop down list of the flag modal would function and also used a display property so that the user can choose a proper flag.

In code snippet 2-FlagModel I had to add a few fields to the flag class to ensure proper functionality.

In code snippet 3-FlagController I had to make a Create action result so that the flag would be created and send the proper data to the flag data table. This included the Post's ID, the User doing the flagging, what date the flag was created and the type of flag the user selected.

In picture 4-CreateFlagViews I modified the paragraph to ask the user why they found the post offensive. I also added an action link so that when the user hits the "create" button when they create the flag, it will return them to the Travelogue page instead of throwing an error or returning to the home page like it was doing before.

In picture 5-PostInteractionViews I removed a "Submit" button that was also appearing on the flag modal. It was redundant to have a "Create" button as well as a "Submit" button. 

In picture 7-Travelogue you can see the main page where the flag modal is situated, and where the end user can create a flag.

As you can see in pictures 8-FlagModal, 9-DropDownList and 6-FlagTable - the completed flag modal now comes with a drop down list for the user to choose from for flag options. It also communicates with the flag data table so that an admin can see which user, which post, what type of flag the user chose and what date and time the user flagged the post. This ensures that the admin can easily find the post that has been flagged for review and take necessary action. They can also inform the user who flagged the post as to which action has been taken to rectify said flag, and also inform the original poster that their post has been flagged and what action has been taken. 


# Built/Edited With
This is an ASP.NET and MVC project built using Microsoft Visual Studio (2017)

# Authors
This is a student driven project that has been built and maintained by the students and faculty of The Tech Academy. 
