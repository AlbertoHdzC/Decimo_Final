   M S B A M L   `   `   `  ����d  `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF  5   	    Radiation_project"   Radiation_project.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   bWPFRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     5   	     � Title$  	Radiation��5   	   $��539.916��6   $	��700��6,   
������� � WindowStartupLocation$ CenterScreen=�5      .��5      �  � ColumnDefinitions 5   
   �� 5	      $
��449* �6   �� 5
      $
��245* �6   .+�5   
   �� $��
Longitude:��6   $
��Left=�6%   $��284,355,0,0q�6@   $	��Top=�6U   $��26��6m   $��65��6y   �� 5   
   -   5         ��Name$ longitudeTB��5      $
��Left=�6'   $��23��6B   $��359,359,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $
��0.00��6w   $	��Top=�6�   $	��120��6�   $��2��6�   �� 5   
   $��	Latitude:��6   $
��Left=�6$   $��
16,355,0,0q�6?   $	��Top=�6S   $��26��6k   $��56��6w   �� 5   
   -   5        $ 
latitudeTB��5      $
��Left=�6&   $��23��6A   $��108,359,0,0q�6M   $
 Wrap=�6b   $
��0.00��6v   $	��Top=�6�   $	��120��6�   6�   �� 5   
   -   5         ��Name$ 
CountyList��5      $
��Left=�6'   $	��389��6B   $��93.2,10,0,0q�6O   $	��Top=�6d   $	��139��6|   $��1��6�    �� View 5      �� 5       �� ColumnHeaderStringFormat$ County��6   .P�5      �� $��County��6%    �� Width$ 135px��65   5      5      �� 5   
   -   5        	 ��Name$	 SearchButton��5      $��Search��6'   $
��Left=�68   $��93.2,418,0,0q�6S   $	��Top=�6i   $	��139��6�   $��41��6�   $��1��6�   6�   '   !Microsoft.Maps.MapControl.WPF.Map  5   
   -   5        
  Name$

 bmap��5      $
��Left=�6    $��	44,12,0,0q�6;   $	��Top=�6N   $��2��6f   $	��307��6z   $	��458��6�    � Cursor$ Cross��6�   {�.  +   %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProvider 5      D   >Microsoft.Maps.MapControl.WPF.ApplicationIdCredentialsProvider  5         ApplicationId$F @Amn1lyfxJ6ynWfmWS2yHieCZX2TGckgYF3HAh7t4L4iZA_kxqiS5FV29e9b7ujME��67   5      (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	startDate��5      $
��Left=�6(   $��108,401,0,0q�6C   $	��Top=�6X   $	��120��6p      FirstDayOfWeek$ Monday=�6|      DisplayDateEnd$ 
2017-04-10X�6�     5   
   -   5        $ endDate��5      $
��Left=�6&   $��359,401,0,0q�6A   $	��Top=�6V   $	��120��6n   $��2��6z   �� 5    
   -   5         ��Name$ label��5       $��
Start Date��6   $
��Left=�64   $��
16,400,0,0q�6O   $	��Top=�6c   $��70��6{   �� 5!   
   -	   5        $ 
label_Copy��5!      $��End Date��6$   $
��Left=�67   $��284,400,0,0q�6R   $	��Top=�6g   $��60��6   �� 5"   
   -
   5        $	 updateDB��5"      $��	Update DB��6#   $
��Left=�67   $��
44,444,0,0q�6R   $	��Top=�6f   $	��177��6~   $��20��6�   6�   5$      5%      