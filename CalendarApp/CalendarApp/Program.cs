
using CalendarApp.Entities;

Meeting meeting1 = new()
{
    Title = "Coordination meeting",
    Details = new List<string>() { "Weekly Progress Checks on Tasks",
        "Request for Contract Details from XYZ Company",
        "Revisiting Estimated Project Completion Time" },
    StartTime = new DateTime(2023, 09, 24, 11, 00, 00),
    FinishTime = new DateTime(2023, 09, 24, 13, 00, 00),
    Guests = new () {"carl@yetGen.com", "alex@yetGen.com", "lewis@yetGen.com" },
};

Todo todo1 = new()
{
    Title = "Fixing the interface issue",
    Details = new List<string>() { "Reviewing error data and fixing bugs.",
        "If time permits, updating the user interface."},
    StartTime = new DateTime(2023, 09, 26, 18, 00, 00),
    FinishTime = new DateTime(2023, 09, 28, 19, 00, 00),
    Importance = "High Priority",

};

meeting1.GetNotification();
todo1.GetNotification();