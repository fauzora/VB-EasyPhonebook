## EasyPhonebook

this is CRUD VB.Net8 phonebook application with mysql

## Installation
Just install xampp to run mysql with apache and then paste this to mysql command
```mysql
CREATE DATABASE IF NOT EXISTS phonebook;
```
after that, you can use **`contacts.sql`** file to imports table to database or using 
```mysql
CREATE TABLE IF NOT EXISTS contacts (
    contact_id INT NOT NULL AUTO_INCREMENT,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    phone VARCHAR(255) NOT NULL,
    gender VARCHAR(255) NOT NULL,
    address VARCHAR(255) NOT NULL,
    PRIMARY KEY (contact_id)
);
```

## Run Locally
just build application on visual studio and start build to get standalone `.exe` program

## Authors

- [Chairil Fauzi Firmansyah](https://github.com/fauzora)
