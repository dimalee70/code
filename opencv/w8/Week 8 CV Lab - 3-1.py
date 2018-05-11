import cv2
import numpy as np
from matplotlib import pyplot as plt

img = cv2.imread('fly.png')
gray= cv2.cvtColor(img,cv2.COLOR_BGR2GRAY)

surf = cv2.xfeatures2d.SURF_create(400)

kp, des = surf.detectAndCompute(img,None)


surf.setHessianThreshold(50000)

kp, des = surf.detectAndCompute(img,None)

img2 = cv2.drawKeypoints(img,kp,None,(255,0,0),4)

plt.imshow(img2),plt.show()
