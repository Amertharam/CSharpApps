   M S B A M L   `   `   `  ����H  DModbusTCP_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ModbusTCP_AppModbusTCP_App  5   	       ModbusTCP_App.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ModbusTCP_App     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� -   5         ��Name$ 	chkbxBit1��5      $��0��6&   $��0��63   6�   �� 5   
   -   5        $ 	chkbxBit2��5      $��1��6&   $��0��63   6�   �� 5   
   $
��bit1��6   $��0��6   $��1��6,   6>   �� 5   
   $
��bit2��6   $��1��6   $��1��6,   6>   �� 5   
   -   5         ��Name$ 	txtbxBit1��5      $��0��6%   $��2��62   6D   �� 5   
   -   5        $ 	txtbxBit2��5      $��1��6%   $��2��62   6D   �� 5   
   $��Word1��6   $��2��6    $��0��6-   6?   �� 5   
   $��Word2��6   $��3��6    $��0��6-   6?   �� 5   
   $��Word1��6   $��4��6    $��0��6-   6?   �� 5    
   $��Word2��6   $��5��6    $��0��6-   6?   �� 5!   
   -   5        $ txtboxReadReg1��5!      $��2��6*   $��1��67   6I   �� 5"   
   -   5        $ txtboxReadReg2��5"      $��3��6*   $��1��67   6I   �� 5#   
   -   5        $ txtboxWriteReg1��5#      $��4��6,   $��1��69   6K   �� 5$   
   -	   5        $ txtboxWriteReg2��5$      $��5��6,   $��1��69   6K   �� 5%   
   -
   5        $��2��5%      $��2��6   .��6K   Read6R   �� 5&   
   -   5        $��4��5&      $��2��6   .��6L   Write6T   5'      5(      