
Namespace Splash.Konektor
    Public NotInheritable Class SettingOpsi

        Public Sub New()
        End Sub

        Public Shared Konf_Client As String = "[client]"
        Public Shared Konf_Client_Port As String = "3306"
        Public Shared Konf_mysql As String = "[mysql]"
        Public Shared Konf_mysql_defaultcharset As String = "utf8"
        Public Shared Konf_mysql_noautorehash As String = "no-auto-rehash"
        Public Shared Konf_mysqld As String = "[mysqld]"
        Public Shared Konf_mysqld_mysqld_Port As String = "3306"
        Public Shared Konf_mysqld_basedir As String = mdlstring.ADD_QUOTE_ON_SQL("D:/mysql", Limiter.DoubleQoute)
        Public Shared Konf_mysqld_datadir As String = mdlstring.ADD_QUOTE_ON_SQL("D:/mysql/data", Limiter.DoubleQoute)
        Public Shared Konf_mysqld_socket As String = mdlstring.ADD_QUOTE_ON_SQL("MySQL", Limiter.DoubleQoute)
        Public Shared Konf_mysqld_skip_locking As String = ""
        Public Shared Konf_mysqld_key_buffer As String = ""
        Public Shared Konf_mysqld_max_allowed_packet As String = ""
        Public Shared Konf_mysqld_table_cache As String = ""
        Public Shared Konf_mysqld_sort_buffer_size As String = ""
        Public Shared Konf_mysqld_net_buffer_length As String = ""
        Public Shared Konf_mysqld_read_buffer_size As String = ""
        Public Shared Konf_mysqld_read_rnd_buffer_size As String = ""
        Public Shared Konf_mysqld_myisam_sort_buffer_size As String = ""
        Public Shared Konf_mysqld_ft_min_word_len As String = ""
        Public Shared Konf_mysqld_ft_max_word_len As String = ""
        Public Shared Konf_mysqld_ft_stopword_file As String = ""
        Public Shared Konf_mysqld_default_time_zone As String = ""
        Public Shared Konf_mysqld_log_error As String = ""
        Public Shared Konf_mysqld_pid_file As String = ""
        Public Shared Konf_mysqld_general_log As String = ""
        Public Shared Konf_mysqld_general_log_file As String = ""
        Public Shared Konf_mysqld_slow_query_log As String = ""
        Public Shared Konf_mysqld_slow_query_log_file As String = ""
        Public Shared Konf_mysqld_enable_named_pipe As String = ""
        Public Shared Konf_mysqld_skip_federated As String = ""
        Public Shared Konf_mysqld_server_id As String = ""
        Public Shared Konf_mysqld_tmpdir As String = ""
        Public Shared Konf_mysqld_innodb_data_home_dir As String = ""
        Public Shared Konf_mysqld_innodb_data_file_path As String = ""
        Public Shared Konf_mysqld_innodb_log_group_home_dir As String = ""
        Public Shared Konf_mysqld_innodb_buffer_pool_size As String = ""
        Public Shared Konf_mysqld_innodb_additional_mem_pool_size As String = ""
        Public Shared Konf_mysqld_innodb_log_file_size As String = ""
        Public Shared Konf_mysqld_innodb_log_buffer_size As String = ""
        Public Shared Konf_mysqld_innodb_flush_log_at_trx_commit As String = ""
        Public Shared Konf_mysqld_character_set_server As String = ""
        Public Shared Konf_mysqld_default_character_set As String = ""
        Public Shared Konf_mysqld_innodb_lock_wait_timeout As String = ""
        Public Shared Konf_mysqldump As String = ""
        Public Shared Konf_mysqldump_quick As String = ""
        Public Shared Konf_mysqldump_max_allowed_packet As String = ""
        Public Shared Konf_isamchk As String = ""
        Public Shared Konf_isamchk_key_buffer As String = ""
        Public Shared Konf_isamchk_sort_buffer_size As String = ""
        Public Shared Konf_isamchk_read_buffer As String = ""
        Public Shared Konf_isamchk_write_buffer As String = ""
        Public Shared Konf_myisamchk As String = ""
        Public Shared Konf_myisamchk_ As String = ""
        Public Shared Konf_key_buffer As String = ""
        Public Shared Konf_sort_buffer_size As String = ""
        Public Shared Konf_read_buffer As String = ""
        Public Shared Konf_write_buffer As String = ""
        Public Shared Konf_ft_min_word_len As String = ""
        Public Shared Konf_ft_max_word_len As String = ""
        Public Shared Konf_ft_stopword_file As String = ""
        Public Shared Konf_mysqlhotcopy As String = ""
        Public Shared Konf_mysqlhotcopy_interactive_timeout As String = ""

        Public Shared ReadOnly Property DoubleQoute As String = Chr(34)
        Public Shared ReadOnly Property SingleQuote As String = Chr(39)
        Public Shared ReadOnly Property Makro = "|"
        Public Shared ReadOnly Property Tab = Chr(10)
        Public Shared ReadOnly Property HashTag = "#"
        Public Shared ReadOnly Property SignD = "$"

        <Flags>
        Public Enum Limiter
            DoubleQoute = 0
            SingleQuote = 1
            Makro = 2
            Tab = 3
            HashTag = 4
            SignD = 5
        End Enum

    End Class
End Namespace


