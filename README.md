# gcp-demo
Quickstart for deploying application and CI/CD in GCP

https://cloud.google.com/sdk/docs/quickstart-macos

gcloud container clusters get-credentials test-random-cluster-py --zone australia-southeast1-a --project central-oath-228105

gcloud builds submit --config cloudbuild.yaml .