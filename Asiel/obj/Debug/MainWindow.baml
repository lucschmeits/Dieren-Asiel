   M S B A M L   `   `   `  ����@  <Asiel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AsielAsiel  5   	       Asiel.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Asiel     5   	   -   5          � Title$  Dieren asiel��5      $��506.103��6   $��1320.224��6.   ���	#FF5F5C3B$��Global Sans Serif)�6V   $��16(�6u   .��5	      � .+�5
   
   �� -   5         ��Name$ ListviewReservering��5
      $
��Left=�60   $	��185��6K   $��	22,21,0,0q�6X   $	��Top=�6k   $	��538��6�    �� View 5      �� 5      .P�5      �� $��Persoon��6%    �� Width$	 160��66    �� DisplayMemberBinding 6B   �� *persoon.naam+�� 5      $
��Dier��6%   $	 160��63    6?   �� *dier.DierSet+�� 5      $��Datum��6%   $	 160��64    6@   �� *reserveerDateTime+5      5      �� 5   
   -   5        $ ListviewDier��5      $
��Left=�6)   $	��185��6D   $��
22,249,0,0q�6Q   $	��Top=�6e   $	��538��6}    �� SelectionMode$ Single=�6�    5      �� 5      .P�5      �� $
��Naam��6%   $	 170��63    6?   �� *naam+�� 5      $��Geslacht��6%   $	 170��67    6C   �� *GeslachtSet+�� 5      $��Diertype��6%   $	 170��67    6C   �� *	DierSet+5      5      �� 5   
   -   5         ��Name$ 	BtnWinkel��5      $��Winkel��6$   $
��Left=�65   $��1041,21,0,0q�6P   $	��Top=�6e   $	��248��6}   $��43��6�   ���	#FF51A060
�������6�   �� 5   
   -   5        $ btnNieuwDier��5      $��
Nieuw Dier��6'   $
��Left=�6<   $��1041,90,0,0q�6W   $	��Top=�6l   $	��248��6�   $��43��6�   ���	#FFFF9B6D
�������6�   �� 5   
   -   5        $ btnNieuwPersoon��5      $��Nieuw Persoon��6*   $
��Left=�6B   $��1041,158,0,0q�6]   $	��Top=�6s   $	��248��6�   $��43��6�   ���	#FFEAFD89���	#FF8171716�   �� 5   
   -   5        $ ListviewPersoon��5      $
��Left=�6,   $	��185��6G   $��611,249,0,0q�6T   $	��Top=�6i   $	��422��6�    5       �� 5!      .P�5"      �� $
��Naam��6%   $	 130��63    6?   �� *naam+�� 5#      $��
Achternaam��6%   $	 140��69    6E   �� *
achternaam+�� 5$      $��
Woonplaats��6%   $	 140��69    6E   �� *
woonplaats+5%      5'      (  "System.Windows.Controls.DatePicker  5(   
   -   5          Name$ DatePickerReservering��5(      $
��Left=�64   $��
611,63,0,0q�6O   $	��Top=�6c   $	��313��6{   �� 5)   
   -	   5        $ BtnReserveer��5)      $��	Reserveer��6'   $
��Left=�6;   $��1041,223,0,0q�6V   $	��Top=�6l   $	��248��6�   $��43��6�   ���	#FFF15748
�������6�   �� 5*   
   $&�� Selecteer datum voor reservering��6   $
��Left=�6;   $��
611,21,0,0q�6V   $	��Top=�6j   
�������6�   5+      5,      