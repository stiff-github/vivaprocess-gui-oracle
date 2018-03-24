CREATE SMALLFILE TABLESPACE "KUHNI_MODUL_DATA" DATAFILE 'd:\oracle\oradata\MODERNDB\DATAFILE\KUHNI_MODUL_DATA.DBF' SIZE 200M REUSE AUTOEXTEND ON NEXT 10240K MAXSIZE 32767M LOGGING EXTENT MANAGEMENT LOCAL SEGMENT SPACE MANAGEMENT AUTO;

CREATE SMALLFILE TABLESPACE "KUHNI_MODUL_IND" DATAFILE 'd:\oracle\oradata\MODERNDB\DATAFILE\KUHNI_MODUL_IND.DBF' SIZE 100M REUSE AUTOEXTEND ON NEXT 10240K MAXSIZE 32767M LOGGING EXTENT MANAGEMENT LOCAL SEGMENT SPACE MANAGEMENT AUTO; 

CREATE SMALLFILE TABLESPACE "KUHNI_MODUL_ROLL" DATAFILE 'd:\oracle\oradata\MODERNDB\DATAFILE\KUHNI_MODUL_ROLL.DBF' SIZE 200M REUSE AUTOEXTEND ON NEXT 51200K MAXSIZE 32767M LOGGING EXTENT MANAGEMENT LOCAL SEGMENT SPACE MANAGEMENT AUTO; 

CREATE SMALLFILE TEMPORARY TABLESPACE "KUHNI_MODUL_TMP" TEMPFILE 'd:\oracle\oradata\MODERNDB\DATAFILE\KUHNI_MODUL_TMP.DBF' SIZE 100M REUSE AUTOEXTEND ON NEXT 10240K MAXSIZE 32767M EXTENT MANAGEMENT LOCAL UNIFORM SIZE 1024K;

-- Create the user 
create user KUHNI_MODUL
  identified by "KUHNI"
  default tablespace KUHNI_MODUL_DATA
  temporary tablespace KUHNI_MODUL_TMP
  profile DEFAULT;
-- Grant/Revoke object privileges 
grant execute on DBMS_RLS to KUHNI_MODUL;
grant select on GV_$SESSION to KUHNI_MODUL;
grant select on V_$SESSION to KUHNI_MODUL;
-- Grant/Revoke role privileges 
grant connect to KUHNI_MODUL;
grant dba to KUHNI_MODUL;
grant exp_full_database to KUHNI_MODUL;
grant imp_full_database to KUHNI_MODUL;
grant javasyspriv to KUHNI_MODUL;
grant javauserpriv to KUHNI_MODUL;
grant java_admin to KUHNI_MODUL;
grant resource to KUHNI_MODUL;
grant select_catalog_role to KUHNI_MODUL;
-- Grant/Revoke system privileges 
grant alter session to KUHNI_MODUL;
grant create any context to KUHNI_MODUL;
grant create any index to KUHNI_MODUL;
grant create any procedure to KUHNI_MODUL;
grant create database link to KUHNI_MODUL;
grant create job to KUHNI_MODUL;
grant create library to KUHNI_MODUL;
grant create materialized view to KUHNI_MODUL;
grant create operator to KUHNI_MODUL;
grant create procedure to KUHNI_MODUL;
grant create sequence to KUHNI_MODUL;
grant create synonym to KUHNI_MODUL;
grant create table to KUHNI_MODUL;
grant create trigger to KUHNI_MODUL;
grant create type to KUHNI_MODUL;
grant create view to KUHNI_MODUL;
grant drop any procedure to KUHNI_MODUL;
grant execute any procedure to KUHNI_MODUL;
grant export full database to KUHNI_MODUL;
grant unlimited tablespace to KUHNI_MODUL;
