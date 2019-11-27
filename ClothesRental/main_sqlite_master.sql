UPDATE sqlite_master SET type = 'table', name = 'outfits_dg_tmp', tbl_name = 'outfits_dg_tmp', rootpage = 5, sql = 'CREATE TABLE outfits_dg_tmp
(
	type text,
	Size char,
	outfit_id integer not null
		constraint outfits_pk
			primary key autoincrement
)';
UPDATE sqlite_master SET type = 'table', name = 'sqlite_sequence', tbl_name = 'sqlite_sequence', rootpage = 6, sql = 'CREATE TABLE sqlite_sequence(name,seq)';
UPDATE sqlite_master SET type = 'table', name = 'outfits', tbl_name = 'outfits', rootpage = 2, sql = 'CREATE TABLE outfits
(
	outfit_type string not null,
	outfit_size char not null,
	outfit_id integer not null
		constraint outfits_pk
			primary key
)';
UPDATE sqlite_master SET type = 'table', name = 'users', tbl_name = 'users', rootpage = 7, sql = 'CREATE TABLE "users"
(
	user_id integer not null
		constraint users_pk
			primary key,
	name string not null,
	lastname string not null,
	nick string not null,
	password string not null
)';
UPDATE sqlite_master SET type = 'table', name = 'customers_list', tbl_name = 'customers_list', rootpage = 3, sql = 'CREATE TABLE "customers_list"
(
	customer_id int
		constraint customers_list_outfits_outfit_id_fk
			references outfits
		constraint customers_list_users_user_id_fk
			references users,
	outfit_id int
)';