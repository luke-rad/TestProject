## Komentari

 - Projekat je u **.NET 8** ali sintaksno nije nista korisceno sto ne bi
   bilo kompatibilno ranijim verzijama (izuzev spajanja Program.cs i
   Startup.cs)
 - Šema baze podataka: Kao ORM koriscen je **EFCore**. U entities nije
   moralo da se dodaje ProductCategory (implicitno bi se napravila
   tabela), ali radimo future-proof u slucaju da je nekad u buducnosti
   potrebno pamtiti novi prop.

## Moguća poboljšanja:

 1. Web API - Ne postoji nikakav validacioni sloj, on bi mogao biti
    ubacen izmedju kontrolera i repozitorijuma.
 2. ExceptionHandling Middleware - Na jednom mestu definisati sta treba
    da se vrati u slucaju bilo koje greske.
 3. Struktura projekta: napravljena da odgovara zahtevima,
    Infrastructure sloj bi se mogao podeliti na dva (lici na Clean
    Architecture)
 4. WinFormClient - sluzi samo da testira http metode, dizajn nije bio u
    prvom planu