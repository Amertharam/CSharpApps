   M S B A M L   `   `   `  ����A  =Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ServerServer  5   	       Server.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Server     5   	   -   5          � Title$  TCP IP Server��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   �� -   5         ��Name$ txtbxIP��5
      $
��Left=�6#   $��
100,15,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $��127.0.0.1:9000��6f   $	��Top=�6|   $	��500��6�   $��30��6�    J� RenderTransformOrigin$ 0.501,-1.177&�6�   �� 5   
   $��Server IP :��6   $
��Left=�6&   $��	10,15,0,0q�6A   $	��Top=�6T   $��30��6l   $��80��6x   �� 5   
   -   5         ��Name$ btnStart��5      $��Start Listening��6#   $
��Left=�6=   $��
609,15,0,0q�6X   $	��Top=�6l   $��30��6�   $	��175��6�   6�   �� 5   
   -   5        $ 	txtbxInfo��5      $
��Left=�6%   $	��262��6@   $��
100,84,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��490��6�    �� IsReadOnlyCaretVisible$
 True��6�   $ �� HorizontalScrollBarVisibility$ Visible=�6�   " �� VerticalScrollBarVisibility$ Visible=�6�   $
��True��6   �� 
IsReadOnly$
 True��6*  �� 5   
   -   5        	 ��Name$	 lstbxClientIP��5      $��600,85,15,89q�6T   �� 5   
   -   5        $ txtbxMessage��5      $
��Left=�6(   $��29��6C   $��100,350,0,0q�6O   $
 Wrap=�6d   $��TextBox��6x   $	��Top=�6�   $	��492��6�   �� 5   
   -   5        $ btnSend��5      $��Send Message��6"   $
��Left=�69   $��28��6T   $��600,350,0,0q�6`   $	��Top=�6u   $	��179��6�   6�   �� 5   
   $��	Message :��6   $
��Left=�6$   $��30��6?   $��
10,350,0,0q�6K   $	��Top=�6_   $��70��6w   �� 5   
   $��Connected Clients :��6   $
��Left=�6.   $��27��6I   $��
608,55,0,0q�6U   $	��Top=�6i   $	��177��6�   �� 5   
   $��Received Text :��6   $
��Left=�6*   $��27��6E   $��
104,52,0,0q�6Q   $	��Top=�6e   $	��177��6}   5      5      