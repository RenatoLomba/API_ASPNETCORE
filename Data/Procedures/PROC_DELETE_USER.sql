CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_DELETE_USER`(
	IN PROC_ID CHAR(36)
)
BEGIN

DELETE FROM user WHERE `Id`=PROC_ID;

END