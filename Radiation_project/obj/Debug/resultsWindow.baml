   M S B A M L   `   `   `  ����L  HRadiation_project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Radiation_projectRadiation_project  5   	   %    Radiation_project.resultsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Radiation_project     5   	     � Title$  Radiation Results��5   	   $��339.116��6#   $��575.789��64   
������� � WindowStartupLocation$ CenterScreen=�5	      .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��451* �6   �� 5      $
��117* �6   .+�5   
   �� -   5         ��Name$ label��5      $��
Latitude: ��6   $
��Left=�64   $��	42,80,0,0q�6O   $	��Top=�6b   �� 5   
   -   5        $ 
label_Copy��5      $��Longitude: ��6$   $
��Left=�6:   $��
42,132,0,0q�6U   $	��Top=�6i   �� 5   
   -   5        $ label1��5      $��
# of Days:��6    $
��Left=�65   $��
42,171,0,0q�6P   $	��Top=�6d   $��59��6|   �� 5   
   -   5        $ label1_Copy��5      $
��WS: ��6%   $
��Left=�64   $��408,132,0,0q�6O   $	��Top=�6d   $��85��6|   $��2��6�   �� 5   
   -   5        $ label1_Copy1��5      $	��Oz:��6&   $
��Left=�64   $��408,171,0,0q�6O   $	��Top=�6d   $��85��6|   $��2��6�   �� 5   
   -   5        $ label1_Copy2��5      $	��Ho:��6&   $
��Left=�64   $��168,239,0,0q�6O   $	��Top=�6d   $��33��6|   �� 5   
   -   5         ��Name$ button��5      $��
Termosolar��6!   $
��Left=�66   $��
26,267,0,0q�6Q   $	��Top=�6e   $��75��6}   $��1��6�   �� 5   
   -   5        $ button1��5      $
��Back��6"   $
��Left=�61   $��
10,267,0,0q�6L   $	��Top=�6`   $��75��6x   6�   �� 5   
   -	   5        $ latitudeLabel��5      $
��0.00��6'   $
��Left=�66   $��
106,80,0,0q�6Q   $	��Top=�6e   $��95��6}   �� 5   
   -
   5        $ longitudeLabel��5      $
��0.00��6(   $
��Left=�67   $��106,132,0,0q�6R   $	��Top=�6g   $��95��6   �� 5   
   -   5        $ 	daysLabel��5      $��0��6#   $
��Left=�6/   $��106,171,0,0q�6J   $	��Top=�6_   $��95��6w   �� 5   
   -   5        $ wsLabel��5      $
��0.00��6!   $
��Left=�60   $��5.716,132,0,0q�6K   $	��Top=�6b   $��95��6z   $��1��6�   �� 5   
   -   5        $ ozLabel��5      $
��0.00��6!   $
��Left=�60   $��5.716,171,0,0q�6K   $	��Top=�6b   $��95��6z   $��1��6�   �� 5   
   -   5        $ h0Label��5      $
��0.00��6!   $
��Left=�60   $��201,239,0,0q�6K   $	��Top=�6`   $��95��6x   �� 5   
   -   5        $ button_Copy��5      $��FotoVoltaico��6&   $
��Left=�6=   $��366,267,0,0q�6X   $	��Top=�6m   $��75��6�   6�   5      5       