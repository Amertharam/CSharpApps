   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ClientClient  5   	       Client.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Client     5   	   -   5          � Title$  TCP IP Client��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   �� -   5         ��Name$ txtbxIP��5
      $
��Left=�6#   $��
100,15,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $��127.0.0.1:9000��6f   $	��Top=�6|   $	��500��6�   $��30��6�    J� RenderTransformOrigin$ 0.501,-1.177&�6�   �� 5   
   $��Server IP :��6   $
��Left=�6&   $��	10,15,0,0q�6A   $	��Top=�6T   $��30��6l   $��80��6x   �� 5   
   -   5         ��Name$ 
btnConnect��5      $��Connect to Server��6%   $
��Left=�6A   $��
609,15,0,0q�6\   $	��Top=�6p   $��30��6�   $	��175��6�   6�   �� 5   
   -   5        $ 	txtbxInfo��5      $
��Left=�6%   $	��262��6@   $��
104,84,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��497��6�    �� IsReadOnlyCaretVisible$
 True��6�   $ �� HorizontalScrollBarVisibility$ Visible=�6�   " �� VerticalScrollBarVisibility$ Visible=�6�   $
��True��6   �� 
IsReadOnly$
 True��6*  �� 5   
   -   5        $ txtbxMessage��5      $
��Left=�6(   $��29��6C   $��107,364,0,0q�6O   $
 Wrap=�6d   $��TextBox��6x   $	��Top=�6�   $	��492��6�   �� 5   
   -   5        $ btnSend��5      $��Send Message��6"   $
��Left=�69   $��28��6T   $��611,365,0,0q�6`   $	��Top=�6u   $	��179��6�   6�   �� 5   
   $��	Message :��6   $
��Left=�6$   $��30��6?   $��	9,363,0,0q�6K   $	��Top=�6^   $��69��6v   �� 5   
   $��Received Text :��6   $
��Left=�6*   $��27��6E   $��
104,52,0,0q�6Q   $	��Top=�6e   $	��177��6}   5      5      