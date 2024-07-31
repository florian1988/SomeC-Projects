﻿namespace DiaryApi.Models;
using System.ComponentModel.DataAnnotations;

public class DiaryEntry
{

    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public DateTime Created { get; set; } = DateTime.Now;
}