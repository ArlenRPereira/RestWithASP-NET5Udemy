CREATE TABLE `books` (
  `id` INT(10) NOT NULL AUTO_INCREMENT ,
  `author` LONGTEXT,
  `launch_date` datetime(6) NOT NULL,
  `price` decimal(65,2) NOT NULL,
  `title` LONGTEXT,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;