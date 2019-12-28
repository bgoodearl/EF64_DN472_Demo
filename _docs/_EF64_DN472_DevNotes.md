# Entity Framework 6.4 .NET Framework 4.7.2 Demo - Dev Notes

## Recognizing Model Attributes

Make sure EFDAL project has dependency on System.ComponentModel.Annotations.
If not, EF Migrations won't pick up annotations on models.
