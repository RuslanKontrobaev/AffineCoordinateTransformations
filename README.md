# Affine Coordinate Transformations
The program implements the application of geometric transformations of transfer, rotation, scaling to a polyline drawn on the canvas

- Transformations are applied to a polyline of arbitrary shape specified by the user
- The program window contains the drawing area, the area for setting the parameters of geometric transformations, the table of coordinates of the vertices of the polyline
- Geometric transformations are implemented by multiplying the transformation matrix by the coordinates of the vertices of the polyline. When setting the parameters of geometric transformations, a matrix corresponding to the specified transformation parameters is displayed on the screen

## Example of how the program works
### The original polyline
![image](https://user-images.githubusercontent.com/109802024/216958639-6880467e-00f7-4d51-b681-c76694efd390.png)

### Applying the transfer transformation
![image](https://user-images.githubusercontent.com/109802024/216958680-287e59f9-5e5e-4d1d-be86-db9870111712.png)

### Applying rotation transformation
![image](https://user-images.githubusercontent.com/109802024/216958730-8f462d8d-7e5b-4823-9b15-fdd2b329c251.png)

### Applying a scaling transformation
![image](https://user-images.githubusercontent.com/109802024/216958777-519f047c-92c6-4414-9b56-6bbf2561d38b.png)

### Combination of rotation, transfer and zoom
![image](https://user-images.githubusercontent.com/109802024/216958898-92f86b59-097e-4a82-845e-c9ab80d55698.png)
