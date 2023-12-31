﻿using Tiktok.API.Domain.EventBusMessages.Interfaces;

namespace Tiktok.API.Domain.EventBusMessages.Events;
 
public record SendMailForgotPasswordEvent : EventBase, ISendMailForgotPasswordEvent
{
    public string Email { get; set; } = null!;
    public string Otp { get; set; }= null!;
    public string FullName { get; set; }= null!;
}