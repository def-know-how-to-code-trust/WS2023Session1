CREATE TABLE Users (
  user_id INT PRIMARY KEY IDENTITY,
  first_name VARCHAR(255) NOT NULL,
  last_name VARCHAR(255) NOT NULL,
  email VARCHAR(255) NOT NULL,
  password VARCHAR(255) NOT NULL,
  user_type VARCHAR(255) NOT NULL
);

CREATE TABLE Subjects (
  subject_id INT PRIMARY KEY IDENTITY,
  name VARCHAR(255) NOT NULL,
  description TEXT NOT NULL,
  code VARCHAR(255) NOT NULL
);

