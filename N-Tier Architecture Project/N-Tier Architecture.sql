


SET IDENTITY_INSERT Members ON;

INSERT INTO Members (ID, Name) VALUES
(1, 'Harun Yahya Ünal'),
(2, 'Alice Johnson'),
(3, 'Hamdiye Nur Kanca'),
(4, 'Diana Prince'),
(5, 'Esma Şen');

SET IDENTITY_INSERT Members OFF;

SET IDENTITY_INSERT Locations ON;

INSERT INTO Locations (ID, Name) VALUES
(1, 'Bartın'),
(2, 'New York'),
(3, 'Adana'),
(4, 'Los Angeles'),
(5, 'Sinop');

SET IDENTITY_INSERT Locations OFF;

SET IDENTITY_INSERT Comments ON;

INSERT INTO Comments (ID, Title, Status, LocationID, MemberID) VALUES
(1, 'Harika bir yer!', 1, 1, 1),
(2, 'Not bad', 0, 2, 2),
(3, 'Çok güzel vakit geçirdik', 1, 3, 3),
(4, 'Could be better', 0, 4, 4),
(5, 'Bayıldım!', 1, 5, 5);

SET IDENTITY_INSERT Comments OFF;