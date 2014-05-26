/*
SQLyog Enterprise - MySQL GUI v6.5
MySQL - 5.6.14 : Database - coinexchange
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

create database if not exists `coinexchange`;

USE `coinexchange`;

/*Data for the table `currencypair` */

insert  into `currencypair`(`CurrencyPairName`,`BaseCurrency`,`QuoteCurrency`) values ('BTC/USD','BTC','USD');

/*Data for the table `ohlc` */

/*Data for the table `order` */

/*Data for the table `permission` */

insert  into `permission`(`PermissionId`,`PermissionName`) values ('CO','Cancel Order'),('PO','Place Order'),('QCOT','Query Closed Orders and Trades'),('QF','Query Funds'),('QLT','Query Ledger Entries'),('QOOT','Query Open Orders and Trades'),('WF','Withdraw Funds');

/*Data for the table `securitykeyspair` */

/*Data for the table `securitykeyspermission` */

/*Data for the table `tickerinfo` */

/*Data for the table `trade` */

/*Data for the table `user` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
