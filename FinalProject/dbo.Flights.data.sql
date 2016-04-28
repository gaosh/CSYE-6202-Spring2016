SET IDENTITY_INSERT [dbo].[Flights] ON
INSERT INTO [dbo].[Flights] ([Id], [Flight_Number], [date], [arrival], [carrier], [E_price], [Eplus_price], [B_price]) VALUES (1, N'CA123     ', N'April 22th', N'Vancouver ', N'A-320     ', N'400       ', N'600       ', N'800       ')
SET IDENTITY_INSERT [dbo].[Flights] OFF
