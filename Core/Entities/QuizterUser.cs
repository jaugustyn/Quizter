﻿using Microsoft.AspNetCore.Identity;

namespace Quizter.Core.Entities;

public class QuizterUser : IdentityUser
{
    [PersonalData] public string FirstName { get; set; }

    [PersonalData] public string LastName { get; set; }

    [PersonalData] public DateTime DateOfBirth { get; set; }
}