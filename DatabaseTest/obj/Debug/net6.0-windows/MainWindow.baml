   M S B A M L   `   `   `  ����M  ILoguri Echipamente, Version=1.0.3.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DatabaseTestDatabaseTest  5   	       DatabaseTest.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DatabaseTest     5   	   -   5          �Name$  
mainWindow��5   	    � Title$ Equipment Database��5   	   $	��770��6$   $
��1356��61   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��1237* �6   �� 5      $
��117* �6    � RowDefinitions 5   
   �� 5      $��0* �6   �� 5      $
��699* �6   �� 5      $	��55* �6   .+�5   
   o� $��3��6   $��3��6    .@�5      m� $��Opțiuni��6   $��28��6(   $��Microsoft Sans Serif)�64   $
��Bold"�6V   $��17(�6h   .@�5      m� -   5         m�Name$ settingsToolStripMenuItem��5      $��Setări��6>   $��Microsoft Sans Serif)�6N   $
��Bold"�6p   $��17(�6�   6�   �� 5      m� 5      -   5        $ exitToolStripMenuItem��5      $��Ieșire��6:   $��Microsoft Sans Serif)�6J   $
��Bold"�6l   $��17(�6~   6�   5      m� 5      $��Afișare��6   $��22��6(   $��Microsoft Sans Serif)�64   $
��Bold"�6V   $��17(�6h   .@�5      m� -   5        $��Echipamente��5      $��Microsoft Sans Serif)�60   $
��Bold"�6R   $��17(�6d   6r   m� 5      -   5        $��	Categorii��5      $��Microsoft Sans Serif)�6.   $
��Bold"�6P   $��17(�6b   6p   m� 5      -   5        $��Elevi��5      $��Microsoft Sans Serif)�6*   $
��Bold"�6L   $��17(�6^   6l   m� 5       -   5        $��Loguri��5       $��Microsoft Sans Serif)�6+   $
��Bold"�6M   $��17(�6_   6m   5!      m� 5#      $��Adaugă��6   $��22��6'   $��Microsoft Sans Serif)�63   $
��Bold"�6U   $��17(�6g   .@�5$      m� $��
Echipament��6   $��Microsoft Sans Serif)�6/   $
��Bold"�6Q   $��17(�6c   .@�5%      m� -   5        $��	Categorie��5%      $��Microsoft Sans Serif)�62   $
��Bold"�6T   $��17(�6f   6t   m� 5&      -	   5        $��
Echipament��5&      $��Microsoft Sans Serif)�63   $
��Bold"�6U   $��17(�6g   6u   5'      m� 5(      -
   5        $
��Elev��5(      $��Microsoft Sans Serif)�6)   $
��Bold"�6K   $��17(�6]   6l   m� 5)      -   5        $	��Log��5)      $��Microsoft Sans Serif)�6(   $
��Bold"�6J   $��17(�6\   6j   5*      m� 5,      $��Caută��6   $��22��6&   $��Microsoft Sans Serif)�62   $
��Bold"�6T   $��17(�6f   .@�5-      m� $��
După elev��6   $��Microsoft Sans Serif)�6.   $
��Bold"�6P   $��17(�6b   m� 5.      $��După echipament��6   $��Microsoft Sans Serif)�64   $
��Bold"�6V   $��17(�6h   5/      50      &   System.Windows.Controls.DataGrid  52   
   -   5          Name$ 
dataOutput��52      $��	8,32,10,3q�6'   $��2��6:   $��1��6K   $��2��6[   $��Microsoft Sans Serif)�6o   $��18(�6�      CanUserAddRows$ False��6�      CanUserDeleteRows$ False��6�      CanUserSortColumns$ False��6�   	   CanUserReorderColumns$	 False��6�   
   
IsReadOnly$

 True��6	  6  �� 54   
   -   5         ��Name$ 
btnRefresh��54      $��Refresh��6%   $��12,10,10,10q�67   $��2��6L   $��Microsoft Sans Serif)�6\   $
��Bold"�6~   $��17(�6�   $��2��6�   6�   �� 55   
   -   5        $ 	btnReturn��55      $��Returnat��6$   $��1132,10,0,10q�67   $��1��6M   $��Microsoft Sans Serif)�6]   $
��Bold"�6   $��17(�6�   $��2��6�   $y�Hidden=�6�   56      57      