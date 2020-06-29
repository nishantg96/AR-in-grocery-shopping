# AR in Grocery Shopping

The main idea is to develop an app that helps user understand an edible product much more easily. There are times when the packaging of a product does not always show all the details properly. The aim is to provide the user as much details about the product as possible like details on nutrition values, allergens present, discounts on the product, alternatives to the same product etc.
To do so the user must first scan the product using the application. There are two possible ways in which the application can be realized:

1. Once the product is scanned, the app will show the user virtual buttons with options of what kind of detail does the user want. For example, there would be a virtual button labelled as Nutrition Values which when touched would show all the nutrition content of the product and so on.
2. Alternatively, all the information can be seen on the bottom of the screen where the user can swipe to get more details. For example, once the product is scanned the nutritional values would be first shown on the bottom of the screen, to go the next page the user has to swipe left and the details about allergens present would be shown and so on.

Additionally, the user would be able to see if the product has any applicable promotional offers or discounts on it by looking at a banner on top of the product if any.
The app will be created using Unity and the Vuforia SDK.

**Prerequisites**

```
* Unity Editor: The project is created in Unity version 2018.4.
* Vuforia SDK: The vuforia engine 9.1 has been imported and used with Unity.
* Target Image: An example target image link has been uploaded here.
* Vuforia compatible android smartphone.
```


**Settings to keep in mind:**

```
* Selecting "Android" platform for creating the app.
* In player settings un-check "Android TV compatibility" and turn on "Vuforia Augmented Reality Support".
* The target image is developed in Vuforia developer portal so it is necessary to add the "Vuforia License Key" in Vuforia Configuration in Unity.
* The created target database has to be imported into unity to use it.
```




**Target Image**

The Target image is the image that the Vuforia Engine can identify and track. The Engine identifies and traces the image by assessing extracted natural elements from the camera image alongside a recognized target resource database which is rich in features. Target images can use any planar image that offers adequate element to be identified by Vuforia Engine. Designing Image Targets comprises of two phases. The first step is to create or choose your target images and make sure they maintain the directions in the following guides for sizing, defining, and enhancing the images. To do so we have to follow these steps:

```
1. Open Vuforia Target Manager after creating an account on it. 
2. Click on Add Database and give it a name. Make sure you select "Device" type.
3. Click on the created database and go to "Add Target". Choose the type of target, upload the image,give it a size and name the image target.
4. Once the target is added, the image would be processed and a rating would be given to it. Make sure it has a good rating so that the tracking is efficient.
5. Click on "Download Database" and import the unity package in the Unity Editor.
```


**Adding Virtual Buttons**

```
1. While on the TargetImage tab, in the Inspector section scroll down to find the "Add Virtual button" option.
2. Once clicked on it, a virtual button would be added to the scene. Next resize, scale and place it on a feature rich place on the image itself.
3. Next, in order to add a visible icon to it, add a plane on top of the button by going to the 3D object option. 
4. Add a visible material to the plane and insert text on top of it if needed.
5. Repeat the above steps to create more virtual buttons.
6. Finally, add a C# script and assign the buttons to perform a set of actions.
```

