   M S B A M L   `   `   `  ����>  :123, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_123_123  5      clr-namespace:_123_123  5
          _123.LoginPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:_123     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      local1clr-namespace:_123  5
         MaterialDesignBody#���   5      $��Regular"�5   	   $��18(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper N� 
Background# �  5   
     MaterialDesignFont N� 
FontFamily# �  5   	    N� Title$ 	LoginPage��5       � DataContext 5      �� *Login+  Locator �� Source# [  � 	Resources 5      3  -_123.ParametrizedBooleanToVisibilityConverter , (ParametrizedBooleanToVisibilityConverter��%   &	         5   
   69   5      .��5      )  #MaterialDesignThemes.Wpf.DialogHost     IsOpen 5   	   �� *IsOpenDialog+	 �� FallbackValue$	 False��
   DialogContent
 5   
   �� 5      $
��Auto��6   $
��Auto��6#   ._�5      �� $��16q�6   .+�5      �� ��6    �� *	Message+�� 5      $��0 10 0 0q�6    " MaterialDesignFlatAccentButton#��[ 6/   $��Закрыть��5    !   ���	#FFFF6D00$��90��6J   $��30��6U   ��6a   �� *CloseDialodCommand+5!      5"      .��5$   
   ��  �� CornerRadius$ 25��6   $��30q�6#   ._�5%   
   �� $��28q�6   .+�5&      �� $��Login��6   $��30(�6%   $��Center=�64   �� 5(      -   5        $��txtUsername��5)      $
��0 10q�5*       ( $MaterialDesignFilledTextFieldTextBox#��[ 5+      $	��Top=�5,       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5.      $	��400��5/      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��50      {�51      ��  �� Path$ 	IsChecked� �� ElementName$9 3MaterialDesignFilledTextFieldTextBoxEnabledComboBox��.��6z   ��52      �� 53      $ Username�6    �� UpdateSourceTrigger$ PropertyChanged=�6.    �� ValidationRules 54      !  _123.NotEmptyValidationRule  55        _123.MinimumCharacterRule  56         MinimumCharacters$ 3��69      _123.MaximumCharacterRule  57         MaximumCharacters$ 20��69   59      .��5:       5;      G� 5=      -   5        $��
txtPassord��5>      $
��0 15q�5?      $	��Top=�5@      $ Password��5B       J� RenderTransformOrigin$ 0.494,0.469&�6?   $��72��6c   {�5A      �� *	IsChecked+$A ;MaterialDesignFilledPasswordFieldPasswordBoxEnabledComboBox����5C      �� 5D       �� 
TargetType" G�6    0 ,MaterialDesignFilledPasswordFieldPasswordBox �� BasedOn# [ 65   �5E      �� 5F        _123.PasswordBoxAssistant �� Property �@ BindPassword �� Value . 6X   �� 5G       �@ BoundPassword 5H   "   �� 5I   &   $ Password�6.   $ PropertyChanged=�6>    �� Mode$ TwoWay=�6d    5J   *     5K   .     5L   .   $ 6��6I     5M   .   $ 24��6I   5O   '   5Q      5S      5U      �� 5V      -   5         ��Name$ 	logsubmit��5V      $��Login��6,   $
��60 0q�6<   
�������$��20(�6]   ��6l   �� *LoginCommand+�� 5W      $��Center=�6   .��62   or66   �� 5X      -   5        $	 reg��5X      $��Registration��6"   $
��60 0q�69   
�������$��20(�6Z   ��6h   �� *
regCommand+5Y      5Z      5[      5\      