   M S B A M L   `   `   `  ����  Shutdown Manager     WpfApplication3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Shutdown Manager��5   	   $	��600��6"   $	��600��6/    � 
ResizeMode$ CanMinimize=�6;    � WindowStartupLocation$ CenterScreen=�6T    � WindowStyle$
 None=�6y   ���	#FFF0F0F0 � Icon$ StartUp\Icon.png��6�   .��5      � .+�5   
   �� -   5        $��Shutdown Manager��5   +   $
��Left=�6F   $��65,3,0,0q�6a   $	��Top=�6s   $	��453��6�   ���	#FF646464$��Segoe UI Light)�6�   $��20(�6�   $��42��6�   �� 5   
   -   5         ��Name$ 	HHDisplay��5      $
��Left=�6%   $	��190��6@   $��
10,203,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $��10��6u   $	��Top=�6   $	��190��6�   $��Segoe UI Light)�6�   $	��130(�6�    �� TextAlignment$ Center=�6�   ���	#FFE4E4E4���	#FFE4E4E4���	#FF606060$��RightToLeft=�6O   �� 
IsReadOnly . 6k  �� 5   
   -   5        $ 	MMDisplay��5      $
��Left=�6%   $	��190��6@   $��205,203,0,0q�6M   $
 Wrap=�6b   $��10��6v   $	��Top=�6�   $	��190��6�   $��Segoe UI Light)�6�   $	��130(�6�   $ Center=�6�   ���	#FFE4E4E4���	#FFE4E4E4���	#FF606060$��RightToLeft=�6,   . 6l  �� 5	   
   -   5        #��[" �5	      $	��▲��6N   $
��Left=�6Z   $��
10,161,0,0q�6u   $	��Top=�6�   $	��190��6�   $��37��6�   ���	#FFE7E7E7���	#FFE7E7E7���	#FF616161	 � ToolTip$	 Increase Hour��6  �� 5
   
   -   5        #��[" �5
      $	��▲��6N   $
��Left=�6Z   $��205,161,0,0q�6u   $	��Top=�6�   $	��190��6�   $��37��6�   ���	#FFE7E7E7���	#FFE7E7E7���	#FF616161$	 Increase Minute��6  �� 5   
   -   5        #��[" �5      $	��▼��6N   $
��Left=�6Z   $��
10,398,0,0q�6u   $	��Top=�6�   $	��190��6�   $��37��6�   ���	#FFE7E7E7���	#FFE7E7E7���	#FF616161$	 Decrease Hour��6  �� 5   
   -   5        #��[" �5      $	��▼��6N   $
��Left=�6Z   $��205,398,0,0q�6u   $	��Top=�6�   $	��190��6�   $��37��6�   ���	#FFE7E7E7���	#FFE7E7E7���	#FF616161$	 Decrease Minute��6  �� 5   
   -   5        #��[" �5      $��SET TIME��6N   $
��Left=�6a   $��457,550,0,0q�6|   $	��Top=�6�   $	��133��6�   $��40��6�   $��Segoe UI Semibold)�6�   $��18(�6�   
����������	#FF7E7E7E���	#FF7E7E7E60  �� 5   
   $��10,0,541,551q�6   $��Icon.png��6&   $
��Fill=�68   �� 5   
   -	   5        #��[" �5      $	��✖��6N   $
��Left=�6Z   $��	558,0,0,0q�6u   $	��Top=�6�   $��35��6�   $��35��6�   ���	#FFF0F0F0���	#FFF0F0F0���	#FF7E7E7E$	 Close��6  �� 5   
   -
   5        #��[" �5      $��_��6N   $
��Left=�6Z   $��	523,0,0,0q�6u   $	��Top=�6�   $��35��6�   $��35��6�   ���	#FFF0F0F0���	#FFF0F0F0���	#FF7E7E7E$
��Bold"�6�   $��15(�6  $	 Minimize��64  �� 5   
   -   5        $ 	TTDisplay��5      $
��Left=�6%   $	��190��6@   $��400,203,0,0q�6M   $
 Wrap=�6b   $��AM��6v   $	��Top=�6�   $	��190��6�   $��Segoe UI Light)�6�   $	��125(�6�   $ Center=�6�   ���	#FFE4E4E4���	#FFE4E4E4���	#FF606060$��RightToLeft=�6,   . 6k  �� 5   
   -   5        #��[" �5      $	��▲��6N   $
��Left=�6Z   $��400,161,0,0q�6u   $	��Top=�6�   $	��190��6�   $��37��6�   ���	#FFE7E7E7���	#FFE7E7E7���	#FF616161$	 Change Meridian ��6  �� 5   
   -   5        #��[" �5      $	��▼��6N   $
��Left=�6Z   $��400,398,0,0q�6u   $	��Top=�6�   $	��190��6�   $��37��6�   ���	#FFE7E7E7���	#FFE7E7E7���	#FF616161$	 Change Meridian ��6  5      5      