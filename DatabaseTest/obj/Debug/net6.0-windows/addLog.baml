   M S B A M L   `   `   `  ����M  ILoguri Echipamente, Version=1.0.3.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DatabaseTestDatabaseTest  5   	       DatabaseTest.addLog   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DatabaseTest     5   	     � Title$  addLog��5   	   $	��392��6   $	��560��6%    � 
ResizeMode$ NoResize=�61   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��210* �6   �� 5      $
��111* �6   �� 5      $	��55* �6   .+�5   
   �� $��Categoria echipamentului��6   $
��Left=�63   $��	21,28,0,0q�6N   $	��Top=�6a   $	��513��6y   $��Microsoft Sans Serif)�6�   $��17(�6�   $
��Bold"�6�   $��29��6�   �� 5   
   -   5         ��Name$ cmbCategory��5      $
��Left=�6(   $��	21,57,0,0q�6C   $	��Top=�6V   $	��513��6n   $��Microsoft Sans Serif)�6z   $��17(�6�   $��25��6�   6�   �� 5   
   $��Echipamentul��6   $
��Left=�6'   $��
21,105,0,0q�6B   $	��Top=�6V   $	��513��6n   $��Microsoft Sans Serif)�6z   $��17(�6�   $
��Bold"�6�   $��29��6�   �� 5   
   -   5        $ cmbEquipment��5      $
��Left=�6)   $��
21,134,0,0q�6D   $	��Top=�6X   $	��513��6p   $��Microsoft Sans Serif)�6|   $��17(�6�   $��25��6�   �� 5   
   $��Elevul��6   $
��Left=�6!   $��
21,175,0,0q�6<   $	��Top=�6P   $	��513��6h   $��Microsoft Sans Serif)�6t   $��17(�6�   $
��Bold"�6�   $��29��6�   �� 5   
   -   5        $ 
cmbStudent��5      $
��Left=�6'   $��
21,204,0,0q�6B   $	��Top=�6V   $	��513��6n   $��Microsoft Sans Serif)�6z   $��17(�6�   $��2��6�   $��25��6�   �� 5   
   $��Data împrumutării��6   $
��Left=�6,   $��	18,40,0,0q�6G   $	��Top=�6Z   $	��515��6r   $��Microsoft Sans Serif)�6~   $��17(�6�   $
��Bold"�6�   $��29��6�   $��1��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
selectDate��5      $
��Left=�6)   $��	21,74,0,0q�6D   $	��Top=�6W   $	��217��6o   $��Microsoft Sans Serif)�6{   $��17(�6�   $��1��6�   $��27��6�      DisplayDate$ 
2024-03-24��6�   �� 5   
   -   5         ��Name$ btnSave��5      $
��Save��6"   $��466,0,26,15q�61   $��Microsoft Sans Serif)�6F   $
��Bold"�6h   $��16(�6z   $��2��6�   $��25��6�   $��Bottom=�6�   5      5      