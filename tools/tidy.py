from ruamel.yaml import YAML

yaml = YAML()
with open('../utm.yaml', 'r') as f:
    api = yaml.load(f)

with open('../utm.yaml', 'w') as f:
    yaml.dump(api, f)
