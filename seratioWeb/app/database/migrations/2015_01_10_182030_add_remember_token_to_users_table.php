<?php

use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class AddRememberTokenToUsersTable extends Migration {

	/**
	 * Run the migrations.
	 *
	 * @return void
	 */
	public function up()
{
    Schema::table('users', function(Blueprint $table)
    {
        $table->rememberToken();
    });
}

public function down()
{
    Schema::table('users', function(Blueprint $table)
    {
        $table->dropColumn('remember_token');
    });
}
}

