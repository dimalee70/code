import cv2
import numpy as np

img = cv2.imread('SDU.jpg')
gray= cv2.cvtColor(img,cv2.COLOR_BGR2GRAY)

sift = cv2.xfeatures2d.SIFT_create()

dummy = np.zeros((1,1))

kp = sift.detect(gray, None)

img = cv2.drawKeypoints(gray, kp,dummy, flags=cv2.DRAW_MATCHES_FLAGS_DRAW_RICH_KEYPOINTS)

cv2.imwrite('sift_keypoints.jpg', img)