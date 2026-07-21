module BookingUpForBeauty

// The following line is needed to use the DateTime type
open System

let schedule (appointmentDateDescription: string): DateTime = 
    DateTime.Parse(appointmentDateDescription)

let hasPassed (appointmentDate: DateTime): bool = 
    let isGreater = appointmentDate < DateTime.Now
    isGreater
    
    
let isAfternoonAppointment (appointmentDate: DateTime): bool =
    let afternoon = appointmentDate.Hour >= 12 && appointmentDate.Hour < 18
    afternoon

let description (appointmentDate: DateTime): string = 
    let desc = "You have an appointment on " + appointmentDate.ToString() + "."
    desc
    
let anniversaryDate(): DateTime = 
    let now = DateTime.Now.Year
    DateTime(now, 9, 15)
