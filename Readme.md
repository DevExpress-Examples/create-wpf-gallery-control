<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128640755/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2275)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Create a WPF Gallery Control

This example creates a [WPF GalleryControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.GalleryControl).

![WPF Gallery Control, DevExpress](https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-gallerycontrol-e2275/22.2.2%2B/i/wpf-gallery-control-devexpress.png)

The Gallery control contains two item groups within the [GalleryControl.Gallery](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.GalleryControl.Gallery) collection:

```xaml
<dxb:GalleryControl>
  ItemClick="Gallery_ItemClick"
...
  <dxb:Gallery.Groups>
      <dxb:GalleryItemGroup Name="myGalleryGroup1" Caption="Misc Group">
          <dxb:GalleryItemGroup.Items>
              <dxb:GalleryItem Caption="Schedule" Description="Show schedule" Glyph="pack://application:,,,/Images/address-16x16.png"/>
              <dxb:GalleryItem Caption="Roles" Description="Assign roles" Glyph="pack://application:,,,/Images/role-16x16.png"/>
          </dxb:GalleryItemGroup.Items>
      </dxb:GalleryItemGroup>
      <dxb:GalleryItemGroup Name="myGalleryGroup2" Caption="Persons">
          <dxb:GalleryItemGroup.Items>
              <dxb:GalleryItem Caption="Employees" Glyph="pack://application:,,,/Images/employee-16x16.png"/>
              <dxb:GalleryItem Caption="Persons" Glyph="pack://application:,,,/Images/person-16x16.png"/>
              <dxb:GalleryItem Caption="Users" Glyph="pack://application:,,,/Images/user-16x16.png"/>
          </dxb:GalleryItemGroup.Items>
      </dxb:GalleryItemGroup>
  </dxb:Gallery.Groups>
...
</dxb:GalleryControl>
```

The [Gallery.ItemClick](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.Gallery.ItemClick) event is handled to respond to user clicks on gallery items:

```csharp
private void Gallery_ItemClick(object sender, DevExpress.Xpf.Bars.GalleryItemEventArgs e) {
    MessageBox.Show("The " + e.Item.Caption + " item has been clicked");
}
```

## Files to Review

* [MainWindow.xaml](./CS/GalleryControl_Ex/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/GalleryControl_Ex/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/GalleryControl_Ex/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/GalleryControl_Ex/MainWindow.xaml.vb))


## Documentation

* [GalleryControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.GalleryControl)
* [GalleryControl.Gallery](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.GalleryControl.Gallery)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=create-wpf-gallery-control&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=create-wpf-gallery-control&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
